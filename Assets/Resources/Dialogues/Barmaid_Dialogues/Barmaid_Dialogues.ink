-> main

=== main ===
Salut, si tu veux quelque chose à boire installe-toi j'arrive !
    +[1. Bonjour, je cherche Tante Poeme vous ne l'auriez pas vu ?]
        -> question_1()
    +[2. Ok. merci.]
        -> question_2()

=== question_1() ===
Désolée chérie, mais avec le monde qu'il y a ici j'ai pas le temps de faire connaissance avec les clients... Sinon ça fait longtemps que je serais loin de cette maudite ville !
-> END

=== question_2() ===
Allez, bouge de là j'ai du boulot maintenant.
    +[1. Désolée!]
        -> END
    +[2. Vous êtes d'un aimable ici ...]
        -> END
-> END