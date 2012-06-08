@ModelType cetefas_GameZone.LoginModel

@Code
    ViewData("Title") = "Log in"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
    <h2>Use this form to enter your user name and password.</h2>
</hgroup>

@Using Html.BeginForm(New With {.ReturnUrl = ViewBag.ReturnUrl})
    @Html.ValidationSummary(true, "Log in was unsuccessful. Please correct the errors and try again.")

    @<fieldset>
        <legend>Log in Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.UserName)
                @Html.TextBoxFor(Function(m) m.UserName)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.Password)
                @Html.PasswordFor(Function(m) m.Password)
            </li>
            <li>
                @Html.CheckBoxFor(Function(m) m.RememberMe)
                @Html.LabelFor(Function(m) m.RememberMe, New With {.class = "checkbox" })
            </li>
        </ol>
        <input type="submit" value="Log in" />
    </fieldset>
    @<p>
        @Html.ActionLink("Register", "Register") if you don't have an account.
    </p>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
