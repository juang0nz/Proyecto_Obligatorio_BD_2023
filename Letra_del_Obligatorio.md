#Letra del proyecto

Trabajo obligatorio  Segundo Semestre 2023  El carné de salud es un requisito para todos los trabajadores y por ello la UCU está realizando una campaña de actualización de datos de todos sus funcionarios. 

Mediante una aplicación los funcionarios deberán cargar sus datos y adjuntar comprobante de dicho carné. Los funcionarios que no lo tengan vigente deberán indicar que no lo tienen y apuntarse en una de las posibles fechas que la UCU brinda para que se realicen el carné en la Clínica UCU Salud.  

Es obligación de todos los funcionarios completar el formulario de actualización de datos entre las fechas 01 de noviembre y 15 de noviembre del 2023, luego de esa fecha si el funcionario quiere acceder a completar los datos se le indicará que el periodo fue finalizado. Igualmente se deberá poder modificar la fecha fin de periodo si la UCU así lo quisiera.

Los datos solicitados en el formulario son:  
    • CI 
    • Nombre Completo 
    • Fecha de nacimiento 
    • Si tiene carné de Salud 
        * Fecha de vencimiento  
        * Comprobante (JPG o PDF)  
    
Se solicita una aplicación donde el funcionario pueda acceder a completar el formulario, si el funcionario no está registrado en la base de datos de la universidad se deberá indicar dicho error y redirigir a una página de “alta de funcionario”, en donde se solicitarán además de los datos solicitados en el formulario original 
    • Domicilio completo de residencia 
    • Correo electrónico 
    • Teléfono de contacto  
    
Asimismo, dada la rapidez en que la campaña se ejecuta, es necesario que todos los días se corra un proceso que chequee aquellos funcionarios que no hayan llenado su formulario y se los notifique de alguna forma (puede ser con el envío de un correo electrónico, un WhatsApp, un telegram o simplemente obtener el listado para que se gestione manualmente de alguna forma: por ejemplo, alguien que se encarga de contactar por teléfono a la gente).  

Para esto deberá crear una base de datos relacional (SQL) con al menos, las siguientes estructuras: 

    Logins (LogId, Password) 
    Funcionarios (Ci, Nombre, Apellido, Fch_Nacimiento, Dirección, Teléfono, Email LogId) 
    Agenda (Nro, Ci, Fch_Agenda) Carnet_Salud (Ci, Fch_Emision, Fch_Vencimiento, Comprobante) Periodos_Actualizacion (Año, Semestre, Fch_Inicio, Fch_Fin)  

Pueden, en caso de ser necesario, crear tablas adicionales, pero no modificar las existentes.   Requisitos del entregable: 
    • Script completo de la creación de la base de datos 
    • Aplicación funcional: 
        * Debe compilar 
        * Debe implementar todos los requerimientos funcionales 
    • Instructivo completo para correr la aplicación de forma local (README del repositorio)  

Se valorarán: 
    • Validación de campos en todas las capas (front-end, back-end y base de datos) 
    • Uso de bases de datos key-value para uso de caché 
    • Dockerización de la aplicación y Docker-compose con servicios de app, bases de datos (relacional y no relacional en caso de usar).   

Fecha de entrega: 27/11/2023 a las 23.59.  
Defensas: 1/12/2023 