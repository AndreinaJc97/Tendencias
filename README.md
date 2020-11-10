# Tendencias
Distribucion de equipos
## Pre-requisitos

 * FrameWork v.4
 * Visual Studio Code
 * .Net core 2.0

## Configuración del entorno para el compilador de C#
 
 * Paso 1: Vaya a Panel de control -> Sistema y seguridad -> Sistema . En la opción Configuración avanzada del sistema , haga clic en Variables de entorno como se muestra a continuación:
 
![alt text][logo]

[logo]: https://media.geeksforgeeks.org/wp-content/uploads/20200121161603/System-Setting.jpg "Panel de control -> Sistema y seguridad -> Sistema"

![alt text][logo]

[logo]: https://media.geeksforgeeks.org/wp-content/uploads/20200121161557/Environment-variable-setup-01.jpg "Variables de entorno"

* Paso 2: Ahora, tenemos que modificar la variable "Ruta" en Variables del sistema para que también contenga la ruta al entorno .NET Framework . Seleccione la variable "Ruta" y haga clic en el botón Editar como se muestra a continuación:

![alt text][logo]

[logo]: https://media.geeksforgeeks.org/wp-content/uploads/20200121161603/System-Setting.jpg "Panel de control -> Sistema y seguridad -> Sistema"

* Paso 3: Veremos una lista de diferentes rutas, damos clic en el botón Nuevo y luego agregaremos la ruta donde está instalado .NET Framework .

![alt text][logo]

[logo]: https://media.geeksforgeeks.org/wp-content/uploads/20200129133525/C-Command-Prompt-Environment-Setup.jpg "Editar enviroment variable"

 * Paso 4: Haga clic en Aceptar , guarde la configuración y listo. Ahora para comprobar si la configuración del entorno se ha realizado correctamente, abra el símbolo del sistema y escriba csc .

 ![alt text][logo]

[logo]: https://media.geeksforgeeks.org/wp-content/uploads/20200129133648/C-Command-Prompt-02.jpg "Editar enviroment variable"

## Pasos para ejecutar el programa C # en cmd

* Paso 1: Abra el editor de texto como el Bloc de notas o el Bloc de notas ++ y escriba el código que desea ejecutar. Ahora guarde el archivo con la extensión .cs .

 ![alt text][logo]

[logo]: https://media.geeksforgeeks.org/wp-content/uploads/20200129133648/C-Command-Prompt-02.jpg "Editor de Notas" "Editar enviroment variable"