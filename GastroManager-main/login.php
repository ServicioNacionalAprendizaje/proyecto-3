<?php include 'recursos/head.php';?>
<body>
    <div class="container">
        <form id="loginForm">
            <h1>GASTROMANAGER</h1>
            <div>
                <label for="email">Correo electronico</label>
                <input type="text" id="email" name="email" class="form-camp" required>
            </div>
            <div class="form-login">
                <label for="password">Contraseña</label>
                <input type="password" id="password" name="password" class="form-camp" required>
            </div>
            <input type="submit" class="btn-1" value="INICIAR SESIÓN">
            <div class="password">
                <a href="recuperacion.php">¿Has olvidado la contraseña?</a>
            </div>
            <div class="reg">
                <p>¿No tienes una cuenta?</p>
            </div>
        </form> 
        <a href="registro.php">
            <input type="submit" class="btn-2" value="REGISTRATE">
        </a>
    </div>
    <?php include 'recursos/scripts.php';?>
</body>
<?php include 'recursos/footer.php';?>