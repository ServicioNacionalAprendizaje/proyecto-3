<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="/css/reservas.css">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Alegreya+Sans:ital,wght@0,100;0,300;0,400;0,500;0,700;0,800;0,900;1,100;1,300;1,400;1,500;1,700;1,800;1,900&display=swap" rel="stylesheet">
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Alegreya+Sans:ital,wght@0,100;0,300;0,400;0,500;0,700;0,800;0,900;1,100;1,300;1,400;1,500;1,700;1,800;1,900&family=Nunito:ital,wght@0,200..1000;1,200..1000&display=swap" rel="stylesheet">
    <title>Gastromanager</title>  
</head>
<header>
    <img src="/imagenes/logo.png" alt="logo">
    <h1>GASTROMANAGER</h1>
    <p>Reservas</p>
</header>
<body>
    <form class="restaurant-form">
        <div class="name-rstaurant">
            <label for="name-label">Nombre del Restaurante:</label>
            <input type="text" class="name-input" name="restaurant-name" required>
        </div>
    </form>  
    <form class="reservas-form">
        <div class="hora-fecha-container">
            <div class="title-hora-fecha">
                <p>Horario y dias de atención</p>
            </div>
            <div class="hora-fecha"></div>
                <div class="apertura-cierre">
                    <label for="time" class="label-hora-fecha">Apertura</label>
                    <input class="input-apertura" type="time" required>
                
                    <label for="time" class="label-hora-fecha">Cierre</label>
                    <input class="input-cierre" type="time" required>
                </div>
                <div class="dias-atencion">
                    <p>Dias de atención</p>
                    <form method="post" action="/send/">
                        <input type="checkbox" checked="checked"> Domingo
                        <input type="checkbox" checked="checked"> Lunes
                        <input type="checkbox" checked="checked"> Martes
                        <input type="checkbox" checked="checked"> Miercoles
                        <input type="checkbox" checked="checked"> Jueves
                        <input type="checkbox" checked="checked"> Viernes
                        <input type="checkbox" checked="checked"> Sabado
                    </form>
                </div>
            </div>
        </div>
        <div class="apertura-container">
            <div class="title-aforo">
                <p>Aforo de mesas</p>
            </div>
            <div class="mesas">
                <label for="time">Seleccione la cantidad maxima de personas para una mesa</label>
                <input class="number" required>
            </div>
        </div>
        <div class="guardar">
            <button type="submit" class="btn-guardar">Guardar</button>
        </div>
    </form>
</body>
</html>