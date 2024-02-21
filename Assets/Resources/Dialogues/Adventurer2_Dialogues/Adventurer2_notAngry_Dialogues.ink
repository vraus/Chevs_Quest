-> main

=== main ===
Salut, je sais pas ce que tu me veux mais si tu cherches la bagarre t'es au bon endroit !
    +[1. Non non non je ne cherche pas la bagarre ! Détrompte-toi!]
        -> calme()
    +[2. Elle va me parler autrement la pouffiasse ?]
        -> pas_calme()
    +[3. Je suis simplement à la recherche de Tante Poeme.]
        -> question()
    
    
=== calme() ===
Bon, alors qu'est-ce que tu cherches ?
    + [1. Simplement un paladin du nom de Tante Poeme.]
        -> question()
->END
=== pas_calme() ===
Retrouve-moi dehors ce soir et je te ferai gouter mon épée, sale garce mal élevée! 
-> END
=== question() ===
Tante Poeme ? Ce paladin de malheure jouait avec nous hier au Gwent... il a eu beaucoup de chances, c'était louche.
    +[1. Comment ça, 'nous' ?]
        -> poker_team()
    +[2. D'accord ... merci.]
        -> END
        
=== poker_team() ===
Laisse-moi réfléchir... Il y avait le tavernier, le nain là-bas, mais il était moins bourré et plus grognon, un vieux flétri et un mec louche!
    +[1. Merci pour les renseignements!]
        -> dernier_acte()
        
=== dernier_acte() ===
Pas de soucis. Eh dis moi c'est qui pour toi ce Tante Poeme ?
    + [1. Personne, un connard]
        ->fermeture()
    + [2. Mon amant]
        ->fermeture()
    + [3. Un ami qui s'est perdu]
        ->fermeture()
    
=== fermeture() ===
Je vois...
-> END