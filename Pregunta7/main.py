def suma(a,b):
    return a+b
def resta(a,b):
    return  a-b
def multiplicacion(a,b):
    return a*b
def division(a,b):
    return  a/b

n1= float(input("Ingrese numero 1"))
n2= float(input("Ingrese numero 2"))

print(n1, "+", n2, "=", suma(n1,n2))
print(n1, "-", n2, "=", resta(n1,n2))
print(n1, "*", n2, "=", multiplicacion(n1,n2))
print(n1, "/", n2, "=", division(n1,n2))
