Game-Engines-Tutorial-4

Ethan Kowalchuk
100752686

The player can walk around the area and collide
with enemies, which kills them.  This triggers an event
which plays an audio clip, as well as lowers the player's
health.  I used a singleton approach for the player's health,
and an observer approach for the audio.