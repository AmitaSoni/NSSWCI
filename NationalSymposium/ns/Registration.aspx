<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="NationalSymposium.ns.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">

    <link rel="stylesheet" href="../Styles/bootstrap.min.css" /> 
    <link rel="stylesheet" href="../Styles/main.css" />
    <link href="../Content/themes/base/all.css" rel="stylesheet" />
    <script src="../Scripts/jquery-3.6.0.min.js"></script>
    <script src="../Content/AdminLte310/plugins/toastr/toastr.min.js"></script>
    <link href="../Content/AdminLte310/plugins/toastr/toastr.min.css" rel="stylesheet" />
    <title>Jal Jeevan Mission</title>
</head>
<body>
    <form id="form1" runat="server">
        <header class="header">
            <div class="container">
                <div class="row justify-content-center align-items-lg-center mobile--bg py-2 py-md-3">
                    <div class="col-8 col-md-6 col-lg-5">
                        <a href="index.html" class="logo">
                            <img src="../images/logo.png" alt="logo"></a>
                    </div>
                    <div class="col-4 col-md-6 col-lg-7 text-end">
                        <span>
                            <img src="../images/swachBharatlogo.png" alt="swachBharatlogo" class="swachBharatlogo"></span>
                    </div>
                </div>
            </div>
        </header>

        <div class="main-content">

            <section class="banner">
                <div class="row justify-content-center">
                    <div class="col-11 col-md-12 col-lg-12 text-center">
                        <h2>National Symposium on Safe Water &amp; Chlorination Initiatives</h2>
                    </div>
                    <div class="col-11 col-md-8 col-lg-6">
                        <ul>
                            <li>
                                <span>Date: </span><small>12/12/2023</small>
                            </li>
                            <li>
                                <span>Venue: </span><strong>Auditorium, SPM Niwas, Kolkata</strong>
                            </li>
                            <li>
                                <span>Organised by:</span> Jal Jeevan Mission 
                            </li>
                            <li>
                                <span>Technical Partner: </span>Development Innovation Lab (DIL) and Evidence Action 
                            </li>
                        </ul>
                    </div>
                </div>
            </section>


            <section class="card-section">
                <div class="container">
                    <div class="row justify-content-center">
                        <div class="col-12 text-center">
                            <h4>Registraion Form </h4>
                            <h2>Welcome, User!</h2>
                        </div>
                        <div class="col-12 col-md-6 col-lg-6">
                            <div class="card-wrap">
                                <form>
                                    <div class="row">
                                        <div class="col offset-md-2 col-md-8 offset-sm-2 col-sm-8">
                                            <asp:RadioButtonList ID="rdbParticipants" runat="server">
                                                <asp:ListItem Text="Participant" Value="1" />
                                                <asp:ListItem Text="Speaker/Panelist" Value="0" />
                                            </asp:RadioButtonList>
                                            <asp:RequiredFieldValidator ID="rfvParticipants" runat="server" ErrorMessage="Please Select User" ControlToValidate="rdbParticipants" class="form-text"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col col-md-12">
                                            <div class="input-container">
                                                <i class="fa fa-compass" aria-hidden="true"></i>
                                                <asp:DropDownList ID="ddlStates" runat="server" CssClass="form-select">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvStates" runat="server" ErrorMessage="Please Select States" ControlToValidate="ddlStates" InitialValue="0" class="form-text"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>


                                    <div class="row">
                                        <div class="col col-md-6">
                                            <div class="input-container ">
                                                <i class="fa fa-user" aria-hidden="true"></i>
                                                <asp:TextBox ID="txtName" runat="server" placeholder="Enter Full Name" class="form-control"></asp:TextBox>
                                                <asp:RequiredFieldValidator ControlToValidate="txtName" class="form-text" runat="server" Text="Please enter Name"></asp:RequiredFieldValidator>

                                            </div>
                                        </div>
                                        <div class="col col-md-6">
                                            <div class="input-container">
                                                <i class="fa fa-envelope" aria-hidden="true"></i>
                                                <asp:TextBox ID="txtemail" class="form-control" placeholder="Email Id" runat="server"></asp:TextBox>
                                                <asp:RequiredFieldValidator ControlToValidate="txtemail" runat="server" class="form-text" Text="Please enter Email"></asp:RequiredFieldValidator>

                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col col-md-6">
                                            <div class="input-container">
                                                <i class="fa fa-key" aria-hidden="true"></i>
                                                <asp:TextBox ID="txtpassword" runat="server" EnableTheming="False" placeholder="Enter Password" TextMode="Password" class="form-control"></asp:TextBox>
                                                <asp:RequiredFieldValidator ControlToValidate="txtpassword" runat="server" class="form-text" ErrorMessage="Please enter password"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                        <div class="col col-md-6">
                                            <div class="input-container">
                                                <i class="fa fa-briefcase" aria-hidden="true"></i>
                                                <asp:DropDownList ID="ddlDesignation" runat="server" class="form-select" placeholder="Select Designation">
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvDesignation" runat="server" ErrorMessage="Please Select Designation" ControlToValidate="ddlDesignation" InitialValue="0"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="row">
                                        <div class="col col-md-6">
                                            <div class="input-container">
                                                <i class="fa fa-mobile" aria-hidden="true"></i>
                                                <asp:TextBox ID="txtMobile" runat="server" class="form-control" placeholder="Enter Mobile" TextMode="Phone"></asp:TextBox>
                                                <asp:RequiredFieldValidator ControlToValidate="txtMobile" runat="server" Text="Please enter Mobile Number" class="form-text"></asp:RequiredFieldValidator>
                                                <asp:RegularExpressionValidator ID="revMobile" runat="server" ErrorMessage="Mobile No should 10 digit" ControlToValidate="txtMobile" ValidationExpression="[0-9]{10}"></asp:RegularExpressionValidator>
                                            </div>
                                        </div>
                                        <div class="col col-md-6">
                                            <div class="input-container">
                                                <i class="fa fa-sitemap" aria-hidden="true"></i>
                                                <asp:DropDownList ID="ddlOrganization" runat="server" class="form-select">
                                                    <asp:ListItem Text="Select Organization" Value="" />
                                                </asp:DropDownList>
                                                <asp:RequiredFieldValidator ID="rfvOrganization" runat="server" ErrorMessage="Please Select Organization" ControlToValidate="ddlOrganization" InitialValue="0"></asp:RequiredFieldValidator>
                                            </div>
                                        </div>
                                    </div>

                                    <div class="row">
                                        <div class="col col-md-12">
                                            <div class="remember-wrap text-center">
                                                Already have account?  <a href="Login.aspx" class="remember-btn">Login</a>
                                            </div>

                                            <div class="text-center">
                                                <div class="mb-2 form-check" style="display: inline-block;">
                                                    <input class="form-check-input" type="checkbox" value="" id="flexCheckDefault">
                                                    <label class="form-check-label" for="flexCheckDefault">
                                                        I agree with terms and conditions
                                                    </label>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <asp:Button ID="btnSubmit" runat="server" Text="Submit" class="btn btn-primary common-btn" OnCommand="Submit_Click" />
                                    <asp:Label ID="lblMsg" runat="server" Text=""></asp:Label>
                                </form>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

        </div>

        <footer class="footer text-center">
            <div class="container">
                <div class="row">
                    <div class="col-12">
                        <p>
                            &copy; Copyrights 2023, Lead. All right are reserved.
                        </p>
                    </div>
                </div>
            </div>
        </footer>


    </form>
    <script src="../Scripts/bootstrap.bundle.min.js"></script>

</body>
</html>
