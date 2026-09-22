# Reto 2 – La Ruta del Tesoro Perdido

Aplicación WinForms en C# / .NET 10 que implementa una **lista simplemente
enlazada construida desde cero** para administrar las ubicaciones de una
ruta del tesoro.

## Cómo abrir el proyecto
1. Abre Visual Studio 2026.
2. Archivo → Abrir → Proyecto/Solución → selecciona `Reto2RutaTesoro.slnx`.
3. Presiona `F5` para compilar y ejecutar.

Si tu versión de Visual Studio no reconoce `.slnx`, simplemente abre
directamente `Reto2RutaTesoro/Reto2RutaTesoro.csproj` como proyecto.

## Estructura de archivos

```
Reto2RutaTesoro/
├── Nodo.cs                    → Representa cada ubicación (Id, Nombre, Pista, Peligro, Siguiente)
├── ListaSimple.cs             → Toda la lógica de la lista enlazada (Insertar, Eliminar, Buscar,
│                                 Existe, Modificar, Contar, Recorrer) — sin usar List<T>,
│                                 LinkedList<T>, arreglos ni ninguna colección de .NET como
│                                 almacenamiento.
├── FrmRutaTesoro.cs           → Interacción con el usuario. Los eventos de los botones SOLO
│                                 llaman a métodos de ListaSimple; no manipulan nodos directamente.
├── FrmRutaTesoro.Designer.cs  → Definición de los controles de la interfaz.
└── Program.cs                 → Punto de entrada de la aplicación.
```

## Funcionalidad
- **Agregar**: crea un `Nodo` con los datos capturados y lo inserta en la
  posición correcta (lista ordenada por Id). Si el Id ya existe, se avisa
  con un `MessageBox`.
- **Buscar por ID**: recorre la lista y, si encuentra el nodo, carga sus
  datos en los campos y selecciona la fila en el `DataGridView`.
- **Modificar**: actualiza Nombre, Pista y Peligro del nodo con el Id
  indicado (el Id no se puede cambiar porque define su posición en la lista).
- **Eliminar**: pide confirmación y elimina el nodo del Id indicado,
  reconectando los punteros `Siguiente`.
- **Limpiar campos**: resetea el formulario sin tocar la lista.
- El `DataGridView` se repinta por completo cada vez que cambia la lista,
  recorriéndola desde `Inicio` hasta `NULL` (método `ListaSimple.Recorrer()`),
  tal como pide el reto. Nunca almacena datos por sí mismo.

## Flujo de un botón (ejemplo pedido en el reto)
```
btnEliminar_Click
     ↓
_ruta.Eliminar(id)      // ListaSimple.Eliminar
     ↓
Manipulación de nodos    // dentro de ListaSimple, no en el formulario
     ↓
ActualizarGrid()          // recorre Inicio → NULL y repinta el DataGridView
```

## Ideas para extender (opcional)
- Agregar un `PictureBox` con un mapa e ir resaltando la ubicación
  seleccionada.
- Ordenar visualmente por nivel de peligro.
- Guardar/cargar la ruta en un archivo de texto (leyendo/escribiendo la
  lista enlazada manualmente, sin usar serializadores que dependan de
  colecciones de .NET).
