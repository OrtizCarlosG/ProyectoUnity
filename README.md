# Cliente
Se ha creado este cliente nuevo con el fin de organizar todas las carpetas del proyecto y crear codigos mas limpios y eficientes
# Launcher
El launcher cuenta con un sistema de conexiones TCP/UDP para enviar y recibir paquetes tales como:

## Paquetes del cliente.
- Login: Trae consigo el id que se le ha asignado al cliente en el servidor, el HWID de este mismo, el usuario que haya escrito en el formulario y su contraseña.
- Register: Trae consigo un usuario, una contraseña y su repetida, un email, una respuesta al captcha y el HWID de el usuario que desea registrarse. Todo en string.
- Profile image: No trae nada. Solo la señal para que el servidor devuelva la imagen de perfil de el usuario en cuestion.
- Change profile image: Trae consigo una imagen convertida a string.

## Paquetes del servidor.
- Server ID: sera el id que se nos asignara dentro del servidor de el launcher.
- Login result: sera el resultado de el intento de inicio de sesion, trae consigo una booleana (true/false) y un numero con la cantidad de intentos de inicio de sesion
- Register result: no devuelve nada.
- Ban result: Trae consigo el motivo(string), si es peramanente(booleana) y la duracion de el bloqueo en un string.
- Client key: Trae consigo un string de carecteres aleatorios generados por el servidor los cuales seran ingresados al cliente como parametros al momento de presionar el boton "Jugar".
- Profile image: Trae consigo la foto de perfil de la cuenta que haya iniciado sesion.

## Imagenes

### Cliente:
![Launcher Image](https://i.imgur.com/IhFdhB4.png)

### Server
![Server Image](https://i.imgur.com/ZC5d7Sh.png)
# Server
Como el cliente, este servidor se ha vuelto a crear desde cero para obtener asi un codigo mas limpio y mas organizado.

## Es importante destacar que todo se encuentra bajo construccion.