<?php include 'recursos/head.php';?>
<header>
    <img src="imagenes/logo.png" alt="logo">
    <h1>GASTROMANAGER</h1>
    <p>Contactenos</p>
</header>
<body>
    <form class="restaurant-form">
        <div class="name-rstaurant">
            <label for="name-label">Nombre del Restaurante:</label>
            <input type="text" class="name-input" name="restaurant-name" required>
        </div>
    </form>  
    <form class="contacto-form">
        <div class="horario-container">
            <div class="title-horario">
                <p>Horario y dias de atención</p>
            </div>
            <div class="direccion"></div>
                <div class="">
                    <label for="" class="label-direccion">Direccion</label>
                    <input class="input-direccion" type="text" required>
                
                    <label for="" class="label-direccion">Barrio</label>
                    <input class="input-direccion" type="text" required>
                </div>
            </div>
        </div>
        <div class="contacto-container">
            <div class="title-contacto">
                <p>Contacto</p>
            </div>
            <div class="contacto">
                <label for="" class="label-telefono">Telefono</label>
                <input class="input-telefono" type="tel">
                <label for="" class="label-celular">Celular</label>
                <input class="input-celular" type="tel">
                <label for="" class="label-whatsapp">WhatsApp</label>
                <input class="input-whatsapp" type="tel">
                <label for="" class="label-correo">Correo electronico</label>
                <input type="text" class="form-camp">
            </div>
        </div>
        <div>
            <div class="title-redes">
                <p>Redes Sociales</p>
            </div>
        
             <div class="contacto">
                <label for="" class="label-facebook">Facebook</label>
                <input class="input-facebook" type="tex">
                <label for="" class="label-facebook">Facebook</label>
                <input class="input-facebook" type="tex">
            </div>
            <div class="agregar">
                <button type="button" class="btn-agregar1"> + Agregar producto</button>
            </div>
        </div>
        <div class="guardar">
            <button type="submit" class="btn-guardar">Guardar</button>
        </div>
    </form>
</body>
</html>