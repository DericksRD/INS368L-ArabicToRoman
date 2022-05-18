
# Requerimientos

1. El software debe ser capaz de convertir de números arábigos o decimales a romanos.
2. Para conseguirlo se debe implementar el siguiente algoritmo:

1. Determinar los símbolos para los números específicos del conjunto romano.

| 1 | I |
| --- | --- |
| 5 | V |
| 10 | X |
| 50 | L |
| 100 | C |
| 500 | D |
| 1,000 | M |

2. Si el número es una unidad después de cualquiera en esta tabla, se agrega un 1 (I)
3. Si el número son dos unidades después de cualquiera en esta tabla, se agregan dos 1 (II)
4. Si el número se encuentra una unidad antes de cualquiera de esta tabla, se escribe como el símbolo actual y el símbolo siguiente.

Ej: 4 (IV), 40 (XL), 900 (CM), 51 (LI), 485 (CDLXXXV)

# Criterios de Aceptación

1. Un usuario no puede escribir texto o signos de puntuación.
2. El sistema debe ser desarrollado en inglés y tener todos los textos en español.
3. El sistema debe de contemplar mensajes en respuestas a errores inesperados que puedan ocurrir.
4. El aplicativo no puede durar más de 300 milisegundos en responder.

# Casos de Prueba

- ID: TC01
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 1

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | I |


- ID: TC02
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 5

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | V |


- ID: TC03
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 100

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | C |


- ID: TC04
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 2

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | II |


- ID: TC05
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 4

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | IV |


- ID: TC06
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 40

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | XL |


- ID: TC07
- Diseñado por: Rafael Sánchez
- Revisado por: Lorenzo Solano

**Variables**

@num = 99

| **Paso** | **descripción** | **Resultado esperado** | **Resultado obtenido** | **Estado** |
| --- | --- | --- | --- | --- |
| 1 | Ingresar @num | XCIX |
