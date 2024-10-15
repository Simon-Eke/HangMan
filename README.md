# HangMan

# # Hänga gubbe ()

# I den här övningen kommer du bygga ett spännande spel där du får använda dina programmeringskunskaper! Spelet heter "Hänga gubbe" och målet är att gissa ordet innan du förlorar alla liv. Datorn slumpmässigt väljer ett ord från en lista och din uppgift är att gissa på bokstäver och se om de finns med i ordet. Om du gissar rätt kommer bokstaven att visas, men om du gissar fel förlorar du ett liv. När du har förlorat alla liven är spelet över, men om du lyckas gissa rätt ord innan liven tar slut, vinner du!

# Det finns många sätt att bygga detta spel, och du kan använda vilket programmeringsspråk du vill. För att komma igång kan du börja med att skapa en lista med ord som datorn kan välja slumpmässigt från. Sedan kan du skapa en funktion som tar emot spelarens gissning och jämför den med ordet. Om bokstaven finns i ordet, ska den visas för spelaren. Om gissningen är felaktig, ska spelaren förlora ett liv.

# Här är några tips för att komma igång:

# - Skapa en lista med ord att välja från.
# - Slumpa ett ord från listan vid varje spelomgång.
# - Skapa en loop som fortsätter tills spelaren har vunnit eller förlorat.
# - Ta emot spelarens gissning och jämför den med det valda ordet.
# - Visa rätt bokstäver och dra av ett liv vid felaktig gissning.
# - Kontrollera om spelaren har vunnit eller förlorat och avsluta spelet.

## Extra utmaning

# - Låt spelaren lägga till egna ord till listan över ord som kan förekomma. Spara alla orden i en fil eller i en databas som läses in varje gång programmet körs så att det inte förloras mellan körningarna.
# - Gör mängden liv dynamiska i relation till antalet bokstäver i ordet. Är det ett långt ord kan liven få vara lite fler och är det ett kortare ord kan de vara lite färre.
# - När en spelare klarat ett ord får den direkt ett nytt ord. Spara sedan hur många ord en spelare klarade och visa antal klarade ord när det blir game over.
# - Lägg till en high-score som sparas mellan körningarna av programmet, exempelvis i en fil eller i en databas. Låt en användare få skriva in ett nickname när den förlorat och så sparas det namnet tillsammans med antal klarade ord i din high-score.