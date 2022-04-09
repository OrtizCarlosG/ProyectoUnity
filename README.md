# Cliente
Se ha creado este cliente nuevo con el fin de organizar todas las carpetas del proyecto y crear codigos más limpios y eficientes.

# Launcher
El launcher cuenta con un sistema de conexiones TCP/UDP para enviar y recibir paquetes. Tales como:

## Paquetes del cliente.
- Login: Trae consigo el "id" que se le ha asignado al cliente en el servidor, el "HWID" de éste, el usuario que haya escrito en el formulario y su contraseña.
- Register: Trae consigo en un string un usuario, una contraseña con su repetida, un email, una respuesta al captcha y el "HWID" del usuario que desea registrarse.
- Profile image: Retorna la señal para que el servidor devuelva la imagen de perfil del usuario en cuestión.
- Change profile image: Trae consigo una imagen convertida a string.
- Request Captcha: Envia una señal al servidor para que genere un captcha, se lo asigne al cliente y luego se lo envie.

## Paquetes del servidor.
- Server ID: sera el "id" que se nos asignará dentro del servidor del launcher.
- Login result: será el resultado del intento de inicio de sesión, trae consigo una booleana (true/false) y un número con la cantidad de intentos de inicio de sesión.
- Register result: no devuelve nada.
- Ban result: Trae consigo el motivo(string), si es peramanente(booleana) y la duración del bloqueo en un string.
- Client key: Trae consigo un string de caracteres aleatorios generados por el servidor, los cuales serán ingresados al cliente como parámetros al momento de presionar el boton "Jugar".
- Profile image: Trae consigo la foto de perfil de la cuenta que haya iniciado sesión.
- Return Captcha: Trae consigo el captcha que el cliente necesita introducir como respuesta para registrarse. 

## Imagenes

### Cliente:
![Launcher Image](https://i.imgur.com/IhFdhB4.png)

### Server
![Server Image](https://i.imgur.com/ZC5d7Sh.png)
# Server
Como el cliente, este servidor se ha vuelto a crear desde cero para obtener así un código mas limpio y más organizado.

## Es importante destacar que todo se encuentra bajo construccion.