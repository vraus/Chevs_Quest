-> main

=== main ===
Salut, si tu es ici pour boire un coup, alors bienvenu !
    + [1. Salut, sympa ici...]
        -> basic()
    + [2. Je suis ici pour Tante Poeme]
        -> story()
    + [3. Je voudrais bien une bière...]
        -> biere()
-> END

=== basic() ===
Hmmm...
    +[1. Retour.]
        -> main()
->END

=== story() ===
Je connais personne de ce nom-là. Si tu ne consommes rien, tu sors !
    + [1. Retour.]
        -> main()
-> END

=== biere() ===
Alors tu es au bon endroit ! Il y en as une sur le comptoire que j'ai préparé pour un client qui est parti. Tu n'as qu'a te servir, elle est encore fraîche.
-> END