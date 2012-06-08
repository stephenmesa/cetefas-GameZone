@ModelType cetefas_GameZone.RegisterModel

@Code
    ViewData("Title") = "Register"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
    <h2>Create a new account.</h2>
</hgroup>

<p class="message-info">
    Passwords must be at least @Membership.MinRequiredPasswordLength characters long.
</p>

@Using Html.BeginForm()
    @Html.ValidationSummary()

    @<fieldset>
        <legend>Registration Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.UserName)
                @Html.TextBoxFor(Function(m) m.UserName)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.Email)
                @Html.TextBoxFor(Function(m) m.Email)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.Password)
                @Html.PasswordFor(Function(m) m.Password)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.ConfirmPassword)
                @Html.PasswordFor(Function(m) m.ConfirmPassword)
            </li>
        </ol>
        <input type="submit" value="Register" />
    </fieldset>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
