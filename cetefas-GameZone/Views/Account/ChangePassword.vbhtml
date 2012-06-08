@ModelType cetefas_GameZone.ChangePasswordModel

@Code
    ViewData("Title") = "Change Password"
End Code

<hgroup class="title">
    <h1>@ViewBag.Title.</h1>
    <h2>Use this form to change your password.</h2>
</hgroup>

<p class="message-info">
    Passwords must be at least @Membership.MinRequiredPasswordLength characters long.
</p>

@Using Html.BeginForm()
    @Html.ValidationSummary()

    @<fieldset>
        <legend>Change Password Form</legend>
        <ol>
            <li>
                @Html.LabelFor(Function(m) m.OldPassword)
                @Html.PasswordFor(Function(m) m.OldPassword)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.NewPassword)
                @Html.PasswordFor(Function(m) m.NewPassword)
            </li>
            <li>
                @Html.LabelFor(Function(m) m.ConfirmPassword)
                @Html.PasswordFor(Function(m) m.ConfirmPassword)                
            </li>
        </ol>
        <input type="submit" value="Change password" />
    </fieldset>
End Using

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
