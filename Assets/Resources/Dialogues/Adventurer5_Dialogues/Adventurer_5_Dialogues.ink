-> main

=== main ===
On me confond souvent avec mon grand père ...
    +[1. C'est qui ton grand père ?]
        -> granny()
    +[2. Heuuuu... d'accord.]
        -> END

=== granny() ===
Tu le connais sans doute. Un grand magicien, barbe blanche et longue. Il est connu pour avoir combatut un Balrog il y a longtemps de cela!
C'est vraiment quelqu'un de bien mais vivre dans son ombre ne m'aide pas beaucoup à avancer dans ma quête.
    +[1. Et... C'est quoi ta quête ?]
        -> quest()
    +[2. Supeeeer...]
        ->out()
        
-> END

=== quest() ===
C'est pas encore trop trop précis... mais je traine avec cette archère depuis un moment, on s'amuse bien on fait des quêtes.
Elle m'apprend beaucoup de choses, surtout des éléments de survies. Je crois que c'est une elf je suis pas sûr.
    +[1. D'accord]
        -> quest_1()

=== quest_1() ===
Je ne sais pas si je serais encore là sans elle d'ailleurs. Je suis quelqu'un de timide mais je connais de très bon sortilèges vous savez !
Je sais que beaucoup ne croient plus en la magie... mais il ne faut pas me sous-estimer ! Je suis un descendant de Maiar tout de même! C'est une sacré aide pour la magie !
Bien sûr je ne pense pas pouvoir combattre un Balrog pour l'instant... Surtout que je ne m'y connais pas bien en créatures ni en maniement de l'épée !
    + [1. Tu es jeune, tu as le temps d'apprendre !]
        -> age_1()

=== age_1() ===
Jeune ... J'apprends lentement quand même ! J'ai mit 15 ans à maîtriser mon premier sort ! Et je ne l'utilise déjà presque plus ...
D'ailleurs je ne pense pas que tu puisses devienr mon age ! Alors, à ton avis ?
    + [1. Heuu ... 25 ans ?]
        -> age_3()
    + [2. 987427 ans !]
        -> age_2()
    + [3. Je ne sais pas ...]
        -> age_3()

=== age_2() ===
QUOI ? Non quand meme pas ...
-> age_3()

=== age_3() ===
J'ai 183 ans! Enfin j'aurais 183 d'ici 2 semaines ... Et ça fait à peine 150 ans que j'essaie d'apprendre la magie ! 
C'est le sang Maiar qui m'aide à rester aussi longtemps en vie ... mais d'un autre côté c'est un peu handicapant.
    +[1. Je vois ...]
        -> quest_2()
    +[2. Rappel moi pourquoi tu me racontes tout ça ?]
        -> rappel()
        
=== rappel() ===
On fait la conversation c'est tout!
-> quest_2()
        
=== quest_2() ===
Là on parle avec ce mec un peu bizarre... Il nous propose une quête facile qui paye bien. Ce n'est pas très rassurant mais on aurait bien besoin de l'argent pour refaire le plein!
Je vais retourner avec ma collègue, c'était sympa de faire ta connaissance !
-> END

=== out()
-> END