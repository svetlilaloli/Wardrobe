Console Application<br>
Exercises: Sets and Dictionaries Advanced
# Wardrobe
Write a program that helps you decide what __clothes__ to wear from your __wardrobe__. You will receive the __clothes__, which are currently in your wardrobe, sorted by their __color__ in the following __format__:

"__{color} -> {item1},{item2},{item3}__ …"

If you receive a certain color, which already __exists__ in your wardrobe, just __add__ the clothes to __its records__. You can also receive __repeating items__ for a certain __color__ and you have to keep their __count__.

In the end, you will receive a __color__ and a piece of __clothing__, which you will __look for__ in the wardrobe, separated by a space in the following format:

"__{color} {clothing}__"

Your task is to print all the __items__ and their __count__ for __each color__ in the following format:

"__{color} clothes:__<br>
__* {item1} - {count}__<br>
__* {item2} - {count}__<br>
__* {item3} - {count}__<br>
__…__<br>
__* {itemN} - {count}__"

If you find the __item__ you are __looking for__, you need to print "__(found!)__" next to it:<br>
"__* {itemN} - {count} (found!)__"
## Input
- On the __first line__, you will receive __n__ – the __number of lines__ of clothes, which you will receive.
- On the next __n__ lines, you will receive the __clothes__ in the __format described__ above.
## Output
- Print the __clothes__ from your wardrobe in the __format described__ above.
## Examples
Input|Output
-----|------
4<br>Blue -> dress,jeans,hat<br>Gold -> dress,t-shirt,boxers<br>White -> briefs,tanktop<br>Blue -> gloves<br>Blue dress|Blue clothes:<br>* dress - 1 (found!)<br>* jeans - 1<br>* hat - 1<br>* gloves - 1<br>Gold clothes:<br>* dress - 1<br>* t-shirt - 1<br>* boxers - 1<br>White clothes:<br>* briefs - 1<br>* tanktop - 1
4<br>Red -> hat<br>Red -> dress,t-shirt,boxers<br>White -> briefs,tanktop<br>Blue -> gloves<br>White tanktop|Red clothes:<br>* hat - 1<br>* dress - 1<br>* t-shirt - 1<br>* boxers - 1<br>White clothes:<br>* briefs - 1<br>* tanktop - 1 (found!)<br>Blue clothes:<br>* gloves - 1
5<br>Blue -> shoes<br>Blue -> shoes,shoes,shoes<br>Blue -> shoes,shoes<br>Blue -> shoes<br>Blue -> shoes,shoes<br>Red tanktop|Blue clothes:<br>* shoes - 9
