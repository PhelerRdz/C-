medio = int(input("Cuantos numero de en medio quieres agarrar:"))
refe1 = int(input("Ingrese el Valor de la semilla 1:"))
refe2 = int(input("Ingrese el Valor de la semilla 2:"))
repe = int(input("Cuantas veces quieres repetir:"))
lista = []
NumeroN = refe1
divisorizq = 0
divisorder = 0
pivote = 0
longitud = 0
for i in range(repe):
    numtems = "1"
    divisorizqs = "1"
    divisorders = "1"
    NumeroN = refe1 * refe2
    longitud = len(str(NumeroN))
    pivote = (longitud - medio)
    if (pivote % 2) == 1:
        pivote = (int(pivote) + 1) / 2
        for j in range(longitud):
            numtems = numtems + "0"
        for j in range(longitud - int(pivote) + 1):
            divisorizqs = divisorizqs + "0"
        NumeroN = NumeroN + int(numtems)

    else:
        pivote = pivote / 2
        for j in range(longitud - int(pivote)):
            divisorizqs = int(str(divisorizqs) + "0")
    for k in range(int(pivote)):
        divisorders = int(str(divisorders) + "0")
    divisorizq = int(divisorizqs)
    divisorder = int(divisorders)
    NumeroN = int((NumeroN - (int((NumeroN / int(divisorizq))) * int(divisorizq))) / divisorder)
    refe1 = refe2
    refe2 = NumeroN
    lista.append(NumeroN)
print(lista)
