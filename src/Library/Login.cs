using System;
using System.Security.Cryptography.X509Certificates;
namespace obligatorio
{
public class Login
{
	public Login()
	{
		Public string LogID{ get; set; }
        Public string Password { get; set; }
    }
    // Método para verificar si las credenciales son válidas
    public bool ValidarCredenciales(string passwordIntento)
    {
        // Lógica para verificar si la contraseña proporcionada coincide con la almacenada.
        // Puedes utilizar métodos de hashing y comparar hashes, en lugar de comparar texto plano.
        return Password == passwordIntento;
    }

    // Método para cambiar la contraseña
    public void CambiarContraseña(string nuevaContraseña)
    {
        // Lógica para cambiar la contraseña
        // Puedes aplicar métodos de hashing y almacenar el nuevo hash en lugar de la contraseña en texto plano.
        Password = nuevaContraseña;
    }

    // Método para restablecer la contraseña (por ejemplo, en caso de olvido)
    public void RestablecerContraseña()
    {
        // Lógica para restablecer la contraseña
        // Puedes generar una nueva contraseña temporal y enviarla al usuario por correo electrónico, etc.
    }

    // Método para obtener información sobre el usuario (por ejemplo, para mostrar en la interfaz)
    public string ObtenerInformacionUsuario()
    {
        // Retorna información sobre el usuario (por ejemplo, el ID) según sea necesario.
        return $"Usuario ID: {LogId}";
    }
    }
}