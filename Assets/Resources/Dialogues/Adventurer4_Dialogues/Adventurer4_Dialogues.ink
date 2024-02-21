-> main

=== main ===
Je le trouve louche ce mec, pas toi ? 
    +[1. Qui ça ?]
        -> who()
    +[2. Oui, je suis d'accord...]
        -> continue()
        
=== who() ===
Ce mec-là, encapuchoonné et qui joue avec son couteau... Il veut nous faire faire une quête facile, qu'il dit... Que ça paye bien, qu'il dit.
-> continue()

=== continue() ===
Mais moi je pense que ça sent la détrousse à l'ecarcelle tout ça ! Même si c'est tentant, on aurait bien besoin de faire le plein de vivres avec mon compagnon de route.
    +[1. D'accord, courage pour la suite!]
        -> END
    +[2. Je pense que tu devrais écouter ton instinct !]
        -> instinct()
    
=== instinct() ===
Oui, tu as raison, on va prendre sa quête et voir où cela nous mène ! Merci de ton conseil !
    +[1. C'est pas ce que ... oh et puis zut !]
        -> END
    +[2. Ca fait toujours plaisir de pouvoir aider !]
        -> END

-> END