-> main

=== main ===
Narrateur: Le vieil homme semble fou, il rit seul en se caressant la barbe pensivement.

    +[1. Excusez-moi ... Sauriez-vous me dire où se trouve mon bien-aimé Tante Poeme ?]
        -> enigma_start()
    +[2. Ne pas entammer la conversation avec ce fou]
        -> END
        
=== enigma_start() ===
Je sais bien des choses tu sais... Mais je n'aime pas révéler mes secrets aux ignorants ! Prouve-moi que tu es pleine d'esprit en répondant à ma petite énigme !

    + [1. Non merci, tant pis...]
        -> END
    + [2. Bon si je n'ai pas le choix ...]
        -> question_1()
    + [3. Vieux taré, tu vas me dire où il est, sinon tu finiras embrauché !]
        -> intimidation()

=== intimidation() ===
Bon bon, nul besoin de s'énerver! Il semblerait que le tavernier et votre ami aient joué aux cartes hier. 
Et pour être tout à fait honnête, le tavernier est un très mauvais joueur !
Il a une fâcheuse tendance à mettre les gens qu'il n'aime pas au "cachot", comme il l'appele !
-> END
        
=== question_1() ===
Quel... est ton nom ?
    +[1. hhhuuuuuuh...]
        -> default_bad()
    +[2. Chev]
        -> question_2()
    +[3. J'ai oubliée ...]
        -> default_bad()

=== question_2() ===
Enchanté, je suis Gwyll ! Quelle... est ta quête ? 
    +[1. Je cherche mon idiot d'amant.]
        -> question_3()
    +[2. Je cherche le saint Graal!]
        -> default_bad()
    +[3. Vous pouvez répéter la question ?]
        -> question_2()
-> END

=== question_3() ===
Quel... est la vitesse de déplacment dans l'air d'une hirondelle non chargée ?
    +[1. Comment diable pourrais-je le savoir ?]
        -> default_bad()
    +[2. 13,6 m/s]
        -> default_bad()
    +[3. Une hirondelle africaine ou européenne ?]
        -> enigma_end()
-> END
        
=== default_bad() ===
Dommage, essaye encore !
-> question_1()

=== enigma_end() ===
Hmmmm ... Aucune idée !
Bon tu me semble digne alors je vais te dire. Il semblerait que le tavernier et votre ami aient joué aux cartes hier. 
Et le tavernier est très mauvais joueur ...
Il a une fâcheuse tendance à mettre les gens qu'il n'aime pas au "cachot", comme il l'appele !
-> END

-> END