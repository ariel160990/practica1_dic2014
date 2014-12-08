@echo off
del C:\compi2\reporte\arbol.png
cd C:\Program Files (x86)\Graphviz2.38\bin
start dot.exe -Tpng C:\compi2\reporte\cadenaarbol.txt -o C:\compi2\reporte\arbol.png
exit