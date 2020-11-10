# Tendencias

## Andreina Jimenez Castillo 1070929

Distribucion de equipos
## Pre-requisitos

 * FrameWork v.4
 * Visual Studio Code
 * .Net core 2.0

## Configuración del entorno para el compilador de C#
 
 * Paso 1: Vaya a Panel de control -> Sistema y seguridad -> Sistema . En la opción Configuración avanzada del sistema , haga clic en Variables de entorno como se muestra a continuación:


![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200121161603/System-Setting.jpg "Panel de control -> Sistema y seguridad -> Sistema")

![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200121161557/Environment-variable-setup-01.jpg "Enviroment variable")

* Paso 2: Ahora, tenemos que modificar la variable "Ruta" en Variables del sistema para que también contenga la ruta al entorno .NET Framework . Seleccione la variable "Ruta" y haga clic en el botón Editar como se muestra a continuación:

![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200121164500/Environment-variable-setup-02-1.jpg "Enviroment variable")

* Paso 3: Veremos una lista de diferentes rutas, damos clic en el botón Nuevo y luego agregaremos la ruta donde está instalado .NET Framework .

![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200129133525/C-Command-Prompt-Environment-Setup.jpg "Enviroment variable")

 * Paso 4: Haga clic en Aceptar , guarde la configuración y listo. Ahora para comprobar si la configuración del entorno se ha realizado correctamente, abra el símbolo del sistema y escriba csc .


![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200129133648/C-Command-Prompt-02.jpg "Enviroment variable")

## Pasos para ejecutar el programa C # en cmd

* Paso 1: Abra el editor de texto como el Bloc de notas o el Bloc de notas ++ y escriba el código que desea ejecutar. Ahora guarde el archivo con la extensión .cs .

 ![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200129134015/C-Command-Prompt-00.jpg "Editor de notas")

* Paso 2: compile su código fuente C # con el uso del comando:

- csc File_name.cs

* Si su programa no tiene ningún error, creará un archivo filename.exe en el mismo directorio donde guardó su programa. Suponga que guardó el programa anterior como Hello.cs. Entonces escribirás csc Hello.cs en cmd. Esto creará un archivo Hello.exe .


![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200129134017/C-Command-Prompt-03.jpg "Editor de notas")

* Paso 3: Ahora hay dos formas de ejecutar H ello.exe . Primero, simplemente debe escribir el nombre del archivo, es decir, Hola en el cmd y le dará la salida. En segundo lugar, puede ir al directorio donde guardó su programa y allí encontrará filename.exe. Simplemente tiene que hacer doble clic en ese archivo y le dará la salida.

- Usando el comando:

![alt text](https://media.geeksforgeeks.org/wp-content/uploads/20200129134018/C-Command-Prompt-04.jpg " Linea de comandos")


