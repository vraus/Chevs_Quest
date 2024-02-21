-> main

=== main ===
Salut, si t'es ici pour boire un coup t'es au bon endroit !
    + [1. Livre moi Tante Poeme espèce de mauvais joueur!]
        -> continue_1()
    + [2. Je suis pas ici pour boire des coups, escroc !]
        -> garde()

=== continue_1() ===
Je t'ai déjà dit que je ne savais pas qui c'était ton Tante Poeme !
    + [1. Ah ouais ? Pourtant ce n'est pas ce que m'ont dit les autres clients!]
        -> clients()
    + [2. Vous savez que vous mentez très mal ?]
        -> garde()
        
=== clients() ===
Et qu'est-ce qu'ils disent les autres clients ?
    +[1. Arrêtez un peu, je sais que vous avez joué avec lui au Gwent et que vous avez perdu !]
        -> affrontement()
    +[2. Qu'il est prisonnié de votre cupidité et que votre stupidité vous perdra!]
        -> garde()
        
=== affrontement() ===
Hmm peut-être bien... Ce paladin de malheur trichait ! Et il n'a eu que ce qu'il méritait !
    +[1. Ecoutez, rendez-le moi séance tenante ou je vous préviens je brûle votre établissement]
        -> garde()
    +[2. Ca ne va pas se passer comme ça espèce d'escroc!]
        -> garde()

=== garde() ===
Si vous croyez que je vais me laisser impressionner par une petite garce dans votre genre ! Dégagez d'ici ou j'appelle la garde !
    +[1. Faites donc, mais c'est plutôt vous qui avez le plus à perdre!]
        -> lettre()
        
=== lettre() ===
De quoi est-ce que vous parlez ?
    +[1. C'est bon, j'ai votre attention ?]
        -> lettre_1()
        
=== lettre_1() ===
Eh bien ! Parlez, oiseau de malheur !
    +[1. J'ai en ma possessoin une lettre qui vous est addressé...]
        -> lettre_2()
    
=== lettre_2() ===
Remettez la-moi alors !
    +[1. Vous connaissez son contenu, elle est de la part d'un certain Felon]
        -> lettre_3()

=== lettre_3() ===
Narrateur: Le visage du Tavernier se décomposa. Il n'en revenait pas que vous ayez en votre possession une telle lettre. Son timbre de voix changeat du tout au tout !
Tavernier: D'accord très bien, je comprends. Je vais obtempérer. Tante Poeme est bien avec moi, il est dans la réserve. Je vais le libérer !
Mais je vous en supplie ! Ne dites rien à personne !
    +[1. Cessez de parler et allez le chercher !]
        -> END

-> END