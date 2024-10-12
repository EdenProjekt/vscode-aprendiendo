tareas = []

# Función para agregar una tarea
def agregar_tarea(tarea):
    tareas.append(tarea)
    print(f"Tarea '{tarea}' agregada.")

# Función para mostrar todas las tareas
def mostrar_tareas():
    if not tareas:
        print("No hay tareas pendientes.")
    else:
        print("Tareas pendientes:")
        for i, tarea in enumerate(tareas, 1):
            print(f"{i}. {tarea}")

# Función para eliminar una tarea
def eliminar_tarea(numero_tarea):
    if 0 < numero_tarea <= len(tareas):
        tarea_eliminada = tareas.pop(numero_tarea - 1)
        print(f"Tarea '{tarea_eliminada}' eliminada.")
    else:
        print("Número de tarea no válido.")

# Función principal para interactuar con el usuario
def menu():
    while True:
        print("\nGestión de Tareas")
        print("1. Agregar tarea")
        print("2. Ver tareas")
        print("3. Eliminar tarea")
        print("4. Salir")

        opcion = input("Selecciona una opción: ")

        if opcion == "1":
            tarea = input("Describe la nueva tarea: ")
            agregar_tarea(tarea)
        elif opcion == "2":
            mostrar_tareas()
        elif opcion == "3":
            mostrar_tareas()
            try:
                numero = int(input("Selecciona el número de la tarea a eliminar: "))
                eliminar_tarea(numero)
            except ValueError:
                print("Por favor ingresa un número válido.")
        elif opcion == "4":
            print("¡Hasta luego!")
            break
        else:
            print("Opción no válida, intenta de nuevo.")

# Iniciar el programa
if __name__ == "__main__":
    menu()