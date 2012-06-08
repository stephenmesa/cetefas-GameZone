Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "Modify this template to kick-start your ASP.NET MVC application."

        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "What is this website anyway?"

        Return View()
    End Function
End Class
