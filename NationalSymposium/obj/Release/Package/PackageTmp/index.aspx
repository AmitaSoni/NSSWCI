<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="NationalSymposium.ns.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link rel="stylesheet" href="../Styles/bootstrap.min.css"/>
 <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.8.2/css/all.css" />
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
                 <span><img src="../images/swachBharatlogo.png" alt="swachBharatlogo" class="swachBharatlogo"></span>
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
                     <div class="card-wrap card-wrap-home ">
                         <h3 class="text-center">Participants </h3>
                         <ul>
                             <li>
                                 <strong>1. </strong> National JJM leadership
                             </li>
                             <li>
                                 <strong>2. </strong> Senior Officials from State Water and PHED Departments
                             </li>
                             <li>
                                 <strong>3. </strong> Academic Research Institutions - NEERI, IITs, NITs, NEERI                            
                             </li>
                             <li>    
                                 <strong>4. </strong> Private Sector Organizations in Water Supply & Treatment Works                            
                             </li>
                             <li>    
                                 <strong>5. </strong> WASH Community Organisations - WASH Institute, WaterAid, Piramal Foundation, T ata Trusts, CEEW, Bill & Melinda Gates Foundation                            
                             </li>
                             <li>    
                                 <strong>6. </strong> Representatives from Development Innovation Lab (DIL) and Evidence Action                            
                             </li>
                         </ul>
                     </div>
                 </div>
             </div>
             <div class="d-flex justify-content-center">
                  <a href="ns/Registration.aspx" class="register-btn">Register</a>
                  <a href="ns/Login.aspx" class="login-btn2">Login</a>

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
        <script src="../Scripts/bootstrap.bundle.min.js"></script> 
    </form>
</body>
</html>
