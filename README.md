# HangMan

# # H�nga gubbe ()

# I den h�r �vningen kommer du bygga ett sp�nnande spel d�r du f�r anv�nda dina programmeringskunskaper! Spelet heter "H�nga gubbe" och m�let �r att gissa ordet innan du f�rlorar alla liv. Datorn slumpm�ssigt v�ljer ett ord fr�n en lista och din uppgift �r att gissa p� bokst�ver och se om de finns med i ordet. Om du gissar r�tt kommer bokstaven att visas, men om du gissar fel f�rlorar du ett liv. N�r du har f�rlorat alla liven �r spelet �ver, men om du lyckas gissa r�tt ord innan liven tar slut, vinner du!

# Det finns m�nga s�tt att bygga detta spel, och du kan anv�nda vilket programmeringsspr�k du vill. F�r att komma ig�ng kan du b�rja med att skapa en lista med ord som datorn kan v�lja slumpm�ssigt fr�n. Sedan kan du skapa en funktion som tar emot spelarens gissning och j�mf�r den med ordet. Om bokstaven finns i ordet, ska den visas f�r spelaren. Om gissningen �r felaktig, ska spelaren f�rlora ett liv.

# H�r �r n�gra tips f�r att komma ig�ng:

# - Skapa en lista med ord att v�lja fr�n.
# - Slumpa ett ord fr�n listan vid varje spelomg�ng.
# - Skapa en loop som forts�tter tills spelaren har vunnit eller f�rlorat.
# - Ta emot spelarens gissning och j�mf�r den med det valda ordet.
# - Visa r�tt bokst�ver och dra av ett liv vid felaktig gissning.
# - Kontrollera om spelaren har vunnit eller f�rlorat och avsluta spelet.

## Extra utmaning

# - L�t spelaren l�gga till egna ord till listan �ver ord som kan f�rekomma. Spara alla orden i en fil eller i en databas som l�ses in varje g�ng programmet k�rs s� att det inte f�rloras mellan k�rningarna.
# - G�r m�ngden liv dynamiska i relation till antalet bokst�ver i ordet. �r det ett l�ngt ord kan liven f� vara lite fler och �r det ett kortare ord kan de vara lite f�rre.
# - N�r en spelare klarat ett ord f�r den direkt ett nytt ord. Spara sedan hur m�nga ord en spelare klarade och visa antal klarade ord n�r det blir game over.
# - L�gg till en high-score som sparas mellan k�rningarna av programmet, exempelvis i en fil eller i en databas. L�t en anv�ndare f� skriva in ett nickname n�r den f�rlorat och s� sparas det namnet tillsammans med antal klarade ord i din high-score.