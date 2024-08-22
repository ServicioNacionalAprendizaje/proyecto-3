<?php include 'recursos/head.php';?>
<body>
    <div class="container-1">
        <div class="div-btn-1">
            <label class="label-btn-1">¿ya estas inscrito?</label>
            <a href="login.php">
                <input type="submit"  class="btn-1" value="INICIAR SESIÓN">
            </a>   
        </div>
        <form id="createForm">
            <h1>¡CREA TU CUENTA EN GASTROMANAGER!</h1>
            <div>
                <label for="">Nombre de usuario</label>
                <input type="text"  id="username_create" class="form-camp" required>
            </div>
            <div class="form-registro">
                <label for="">Correo electronico</label>
                <input type="text" id="email_create"  class="form-camp" required>
            </div>
            <div class="form-registro">
                <label for="">Celular</label>
                <input type="tel" id="phone_create" class="form-camp" required>
            </div>
            <div class="form-registro">
                <label for="">Contraseña</label>
                <input type="password" id="pass_create" class="form-camp" required>
            </div>
            <!-- <div>
                <input type="checkbox" class="check" name="Acepto" required>
                <label class="label-check">Acepto las condiciones de uso y privacidad de Gastromanager</label>
            </div> -->
           <div>
                <input type="submit" class="btn-2" value="CREAR CUENTA Y ENTRAR">
            </div>
        </form> 
    </div>
    <div class="container-2">
        <img src="imagenes/logo.png" alt="logo">
    </div>
   <script>
    document.getElementById('createForm').addEventListener('submit', function(event) {
        event.preventDefault();
    
        var usermame = document.getElementById('username_create').value;
        var email = document.getElementById('email_create').value;
        var phone = document.getElementById('phone_create').value;
        var pass = document.getElementById('pass_create').value;
    
        var data = {
            username: usermame,
            email: email,
            phone: phone,
            password:pass
        };
    
        var xhr = new XMLHttpRequest();
        xhr.open('POST', 'https://localhost:7182/api/User/Registro', true);
        xhr.setRequestHeader('Content-Type', 'application/json');
    
        xhr.onreadystatechange = function() {
            if (xhr.readyState === XMLHttpRequest.DONE) {
                if (xhr.status === 200) {
                    console.log('Login exitoso:', xhr.responseText);
                    window.location.href = 'menu.php';
                } else {
                    console.error('Error en el login:', xhr.responseText);
                    alert('Credenciales incorrectas, intenta de nuevo.');
                }
            }
        };
        xhr.send(JSON.stringify(data));
    });
    </script>
    
</body>
</html>