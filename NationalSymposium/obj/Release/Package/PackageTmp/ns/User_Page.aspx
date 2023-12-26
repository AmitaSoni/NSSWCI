<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Page.aspx.cs" Inherits="NSSWC.User_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="../Styles/bootstrap.min.css"/> 
<link rel="stylesheet" href="../Styles/font-awesome.css"/>
<link rel="stylesheet" href="../Styles/main.css"/>
<title>Jal Jeevan Mission</title>
</head>
<body>
    <form id="form1" runat="server">
        <header class="header">
    <div class="container">
        <div class="row justify-content-center align-items-lg-center mobile--bg py-2 py-md-3">
            <div class="col-8 col-md-6 col-lg-5">
                <a href="index.html" class="logo"><img src="../images/logo.png" alt="logo"></a> 
            </div> 
            <div class="col-4 col-md-6 col-lg-7 text-end"> 
                <div class="top-sidebar">
                    <span><img src="../images/swachBharatlogo.png" alt="swachBharatlogo" class="swachBharatlogo"></span>
                    <ul class="dropdown-wrap">
                        <li>
                            <div class="dropdown">
                                <a class="" href="#" role="button" id="dropdownMenuLink" data-bs-toggle="dropdown" aria-expanded="false">
                                    <!-- <img alt="" class="img-circle " src="images/user.png"> -->
                                    <i class="fa fa-user-circle" aria-hidden="true"></i>

                                    <span class="username"><strong>WELCOME </strong> Kiran </span>
                                    <i class="fa fa-angle-down"></i>
                                </a> 
                                <ul class="dropdown-menu" aria-labelledby="dropdownMenuLink">
                                    <li><a class="dropdown-item" href="#">Profile</a></li> 
                                    <li>
                                        <asp:LinkButton ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" class="dropdown-item"/>
                                    </li>
                                </ul>
                            </div>
                        </li>
                    </ul>
                </div>
            </div>
        </div> 
    </div>
</header>
        
        <div class="main-content">

    <section class="banner">
        <div class="row justify-content-center">
            <div class="col-12 col-md-12 col-lg-12 text-center">
                <h2>National Symposium on Safe Water &amp; Chlorination Initiatives</h2>
            </div>
            <div class="col-12 col-md-8 col-lg-6">  
                <ul>
                    <li>
                        <span>Date: </span> <small>12/12/2023</small>
                    </li>
                    <li>
                        <span>Venue: </span> <strong>Auditorium, SPM Niwas, Kolkata</strong>
                    </li>
                    <li>
                        <span>Organised by:</span> Jal Jeevan Mission 
                    </li>
                    <li>
                        <span>Technical Partner: </span> Development Innovation Lab (DIL) and Evidence Action 
                    </li>
                </ul>
            </div>
        </div>
    </section>
    

    <section class="card-section">
        <div class="container">
            <div class="row justify-content-center mb-4">
                <div class="col-12 "> 
                    <h2 class="mb-1 text-center"> Welcome Message / Call to Action </h2>
                    <p>Welcome to the National Symposium on Safe Water and Chlorination Initiatives! Join us as we gather experts, officials, and organizations
                        to share insights and strategies for ensuring clean and safe water</p>
                </div>
                <div class="col-12 col-md-6 col-lg-6"> 
                    <div class="card-wrap card-wrap-home ">
                        <h3 class="text-center">Objectives of the Symposium </h3>
                        <ul>
                            <li>
                                <strong>1. </strong> Knowledge sharing on Safe Water by National JJM, States r representatives and Evidence Action
                            </li>
                            <li>
                                <strong>2. </strong> Disseminate Safe Water ILC Pilot project summary, results &amp; findings
                            </li>
                            <li>
                                <strong>3. </strong> Establish a National Working Group on Safe Water &amp; ILC to recommend policies, interventions and other technically appropriate solutions                            
                            </li>
                            <li>    
                                <strong>4. </strong> Develop and sustain a Safe Water Ecosystem (with representations from NJJM, States, Academic Institutions, Private Sector players, WASH Forum partners, and Evidence Action etc.)                            
                            </li>
                        </ul>
                    </div>
                </div> 
                <div class="col-12 col-md-6 col-lg-6"> 
                    <div class="card-wrap card-wrap-2 mb-4">
                        <h3>Participants </h3>
                        <span>National JJM Leadership</span>
                        <p>Senior Officials from state Water and PHED Departments.</p>
                    </div>
                    <div class="row">
                        <div class="col-12 col-md-6 col-lg-6"> 
                            <div class="card-wrap card-wrap-sm mb-4">
                                <h4><a href="submission-guidelines.html" >Submission Guidelines <i class="fa fa-file" aria-hidden="true"></i></a></h4>
                            </div>
                        </div>
                        <div class="col-12 col-md-6 col-lg-6"> 
                            <div class="card-wrap card-wrap-sm mb-4">
                                <h4> <a href="faq.html">FAQs<i class="fa fa-question-circle" aria-hidden="true"></i></a></h4>
                               

                          </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-12 col-md-6 col-lg-6"> 
                            <div class="card-wrap card-wrap-sm">
                                <h4> <a href="../Download/JJM_Template.pptx" target="_blank">Download Presentation <i class="fa fa-download" aria-hidden="true"></i></a></h4>
                                
                            </div>
                        </div>
                        <div class="col-12 col-md-6 col-lg-6"> 
                            <div class="card-wrap card-wrap-sm">
                                <h4><a href="#" data-bs-toggle="modal" data-bs-target="#staticBackdrop">Upload Presentation <i class="fa fa-upload" aria-hidden="true"></i></a></h4>
                            </div>
                        </div>
                    </div>
                </div>
            </div> 
        </div>
    </section>

 
    
    <!-- Modal -->
    <div class="modal fade" id="staticBackdrop" data-bs-backdrop="static" data-bs-keyboard="false" tabindex="-1" aria-labelledby="staticBackdropLabel" aria-hidden="true">
        <div class="modal-dialog modal-dialog-centered modal-dialog-scrollable">
        <div class="modal-content">
            <div class="modal-header">
            <h5 class="modal-title" id="staticBackdropLabel">Update</h5>
            <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close">
            </button>
            </div>
            <div class="modal-body">
                <form>
                    <!-- <div class="row">
                        <div class="col col-md-12 d-flex justify-content-end">
                            <button type="button" class="btn btn-secondary edit-btn"><i class="fa fa-pencil-square-o" aria-hidden="true"></i>
                            </button>
                        </div>
                    </div> -->
                    <div class="row">
                        <%--<div class="col offset-md-2 col-md-4">
                            <div class="form-check">
                                <input class="form-check-input" type="radio" name="radioDefault" id="radioDefault1" checked>
                                <label class="form-check-label" for="radioDefault1">
                                    PARTICIPANTS
                                </label>
                              </div>
                            </div>
                            <div class="col col-md-4">
                              <div class="form-check">
                                <input class="form-check-input" type="radio" name="radioDefault" id="radioDefault2" >
                                <label class="form-check-label" for="radioDefault2">
                                    PRESENTER
                                </label>
                              </div>
                        </div> --%>
                    </div>

                    <div class="row">
                        <div class="col col-md-12">
                            <div class="input-container mb-3"> 
                                <i class="fa fa-compass" aria-hidden="true"></i> 
                                <asp:DropDownList ID="ddlCategories" runat="server" CssClass="form-select">
<asp:ListItem Text="Select State" Value="" />
</asp:DropDownList>
 
                                <%--<select class="form-select" >
                                    <option selected>Select State Name</option>
                                    <option value="1">Lorem1</option>
                                    <option value="2">Lorem2</option>
                                    <option value="3">Lorem3</option>
                                </select>--%>
                            </div>
                        </div>
                    </div>


                    <div class="row">
                        <div class="col col-md-6">
                            <div class="input-container"> 
                                <i class="fa fa-user" aria-hidden="true"></i>
                                        <asp:TextBox ID="txtName" runat="server" class="form-control"></asp:TextBox>
        <asp:RequiredFieldValidator ControlToValidate="txtName" runat="server" Text="Please enter Name" class="form-text"></asp:RequiredFieldValidator>
                                <%--<input type="text" class="form-control" placeholder="Enter Full Name">
                                <div id="nameHelp" class="form-text"></div>--%>
                            </div>
                        </div>
                        <div class="col col-md-6">
                            <div class="input-container"> 
                                <i class="fa fa-envelope" aria-hidden="true"></i>
<asp:TextBox ID="txtemail" runat="server" class="form-control"></asp:TextBox>
<asp:RequiredFieldValidator ControlToValidate ="txtemail" runat="server" Text="Please enter Email" class="form-text"></asp:RequiredFieldValidator>
                                <%--<input type="email" class="form-control" placeholder="Email Id">
                                <div id="emailHelp" class="form-text"></div>--%>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                       <%-- <div class="col col-md-6">
                            <div class="input-container"> 
                                <i class="fa fa-key" aria-hidden="true"></i>

                                <input type="password" class="form-control" placeholder="Enter Password"> 
                            </div>
                        </div>--%>
                        <div class="col col-md-6">
                            <div class="input-container"> 
                                <i class="fa fa-briefcase" aria-hidden="true"></i>
<asp:DropDownList ID="ddlCategories1" runat="server" class="form-select">
    <asp:ListItem Text="Select Designation" Value="" />
</asp:DropDownList>
                                <%--<select class="form-select" >
                                    <option selected>Select Designation</option>
                                    <option value="1">Lorem1</option>
                                    <option value="2">Lorem2</option>
                                    <option value="3">Lorem3</option>
                                  </select>
                                --%>  
                            </div>
                        </div>
                                                <div class="col col-md-6">
                            <div class="input-container"> 
                                <i class="fa fa-mobile" aria-hidden="true"></i>
                                <asp:TextBox ID="txtMobile" runat="server" class="form-control"></asp:TextBox>
<asp:RequiredFieldValidator ControlToValidate ="txtMobile" runat="server" Text="Please enter Mobile Number"></asp:RequiredFieldValidator>
                                <%--<input type="text" class="form-control" placeholder="Enter Mobile"> --%>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        
                        <div class="col col-md-6">
                            <div class="input-container"> 
                                <i class="fa fa-sitemap" aria-hidden="true"></i>
                                <asp:DropDownList ID="ddlCategories2" runat="server" class="form-select">
    <asp:ListItem Text="Select Organization" Value="" />
</asp:DropDownList>
                                <%--<select class="form-select" >
                                    <option selected>Select Organisation</option>
                                    <option value="1">Lorem1</option>
                                    <option value="2">Lorem2</option>
                                    <option value="3">Lorem3</option>
                                  </select>--%> 
                            </div>
                        </div>

                        <div class="col col-md-6">
    <div class="mb-3 file-upload-wrap"> 
        <asp:FileUpload ID="FileUpload1" runat="server" class="form-control"/>
        <%--<input class="form-control" type="file" id="formFile">--%>
      </div> 
</div>
                    </div>
                    <div class="row">
                        
                    </div>
                   
                </form>
            </div>
            <div class="modal-footer">
               <%-- <button type="submit" class="btn btn-primary">Update</button>--%>
                <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" class="btn btn-primary" />
            </div>
        </div>
        </div>
    </div>
 
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
