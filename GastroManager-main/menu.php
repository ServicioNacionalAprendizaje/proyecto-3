<!DOCTYPE html>
<html lang="es">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="css/menu.css">
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
    <p>Menú</p>
</header>
<body>
    <form class="restaurant-form">
        <div class="name-rstaurant">
            <label for="name-label">Nombre del Restaurante:</label>
            <input type="text" class="name-input" name="restaurant-name" required>
        </div>
    </form>  
    <form class="menu-form">
        <div class="menu-container">
            <div class="category">
                <div>
                    <label for="category-neme" class="category-label">Nombre de la Categoría:</label>
                    <input type="text" class="category-input" name="category-name" required>
                </div>
                <div>
                    <button class="btn-delete-copy" type="button"><img src="/imagenes/borrar.png" alt="Eliminar" class="btn-img"></button>
                    <button class="btn-delete-copy" type="button"><img src="/imagenes/copy.png" alt="Copiar" class="btn-img"></button>
                </div>
            </div>
            <div class="producto-container">
                <div>
                    <label for="item-image"></label>
                    <input type="image" src="/imagenes/imagen.png" class="producto-img" for="item-image" name="item-image">
                </div>
                <div>
                    <label for="item-name" class="producto-label">Nombre:</label>
                    <input type="text" class="producto-input" name="item-name" required>
                    <label for="item-description" class="producto-label-des">Descripción:</label>
                    <textarea name="textarea" rows="10" cols="50" class="textarea-description"></textarea>
                    <label for="item-price" class="producto-label">Precio:</label>
                    <input type="number" class="producto-input" name="item-price" required>
                </div>
                <div>
                    <button class="btn-delete-copy" type="button"><img src="/imagenes/borrar.png" alt="Eliminar" class="btn-img"></button>
                    <button class="btn-delete-copy" type="button"><img src="/imagenes/copy.png" alt="Copiar" class="btn-img"></button>
                </div>
            </div>
            <div class="agregar">
                <button type="button" class="btn-agregar1"> + Agregar producto</button>
            </div>
        </div>

        <button type="button" class="btn-agregar2"> + Agregar Categoría</button>
    </form>
    <div class="guardar">
        <button type="submit" class="btn-guardar">Guardar</button>
    </div>

</body>
</html>
