<script>
    document.getElementById('loginForm').addEventListener('submit', function(event) {
        event.preventDefault();
    
        var email = document.getElementById('email').value;
        var password = document.getElementById('password').value;
    
        var data = {
            username: email,
            password: password
        };
    
        var xhr = new XMLHttpRequest();
        xhr.open('POST', 'https://localhost:7182/api/User/Login', true);
        xhr.setRequestHeader('Content-Type', 'application/json');
    
        xhr.onreadystatechange = function() {
            if (xhr.readyState === XMLHttpRequest.DONE) {
                if (xhr.status === 200) {
                    console.log('Login exitoso:', xhr.responseText);
                    window.location.href = 'inicio.php';
                } else {
                    console.error('Error en el login:', xhr.responseText);
                    alert('Credenciales incorrectas, intenta de nuevo.');
                }
            }
        };
        xhr.send(JSON.stringify(data));
    });

    
</script>