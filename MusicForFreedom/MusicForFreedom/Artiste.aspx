<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Artiste.aspx.cs" Inherits="MusicForFreedom.Artiste" %>

<!DOCTYPE html>
<html >
<head>

  <meta charset="UTF-8">

  <title>S'enregistrer/Se connecter</title>

  <link href='http://fonts.googleapis.com/css?family=Titillium+Web:400,300,600' rel='stylesheet' type='text/css'>

  <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/normalize/5.0.0/normalize.min.css">


  
      <link rel="stylesheet" href="Content/style.css">


  
</head>


<body>
  <div class="form">

      
      <ul class="tab-group">
        <li class="tab active"><a href="#signup">S'enregistrer</a></li>
        <li class="tab"><a href="#login">Se connecter</a></li>
      </ul>
      
      <div class="tab-content">
        <div id="signup">   
          <h1>Enregistrement gratuit</h1>
          
          <form  runat="server">
          

            <div class="field-wrap">
              <label>
                Nom d'artiste<span class="req" >*</span>
              </label>
                    <asp:TextBox ID="tbNomArtiste" runat="server" required="true" autocomplete="off"></asp:TextBox>           
            </div>
        
            <div class="field-wrap">
              <label>
                Présentation<span class="req">*</span>
              </label>
                    <asp:TextBox ID="tbPresentation" runat="server" required="true" autocomplete="off"></asp:TextBox>
            </div>

            <div class="field-wrap">
              <label>
                Logo<span class="req">*</span>
              </label>
              <input type="text" autocomplete="off" title="Logo" />
                <asp:FileUpload ID="fuPhoto" runat="server" required="true" />
                <asp:Label ID="lblErreur" runat="server" Text="le format de l'image est incorrect"></asp:Label>
                    <%--<asp:TextBox ID="TextBox1" runat="server" required="true" autocomplete="off"></asp:TextBox>--%>

            </div>

          <div class="field-wrap">
            <label>
              Addresse mail<span class="req">*</span>
            </label>
                    <asp:TextBox ID="tbMail" runat="server" type="email" required="true" autocomplete="off"></asp:TextBox>>
          </div>
          
          <div class="field-wrap">
            <label>
              Mot de passe<span class="req">*</span>
            </label>
                    <asp:TextBox ID="tbMotdePasse" runat="server" type="password" required="true" autocomplete="off"></asp:TextBox>
          </div>

          <div class="field-wrap">
            <label>
              Confirmez votre mot de passe<span class="req">*</span>
            </label>
                    <asp:TextBox ID="tbMotdePasseConfirm" runat="server" type="password" required="true" autocomplete="off"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tbMotdePasseConfirm" ControlToCompare="tbMotdePasse" ErrorMessage="Attention, vous n'avez pas entré le même mot passe 2 fois!"></asp:CompareValidator>
          </div>
          <div class="field-wrap">
               <label>
                Numéro de compte paypall<span class="req">*</span>
              </label>
                    <asp:TextBox ID="tbPaypall" runat="server" required="true" autocomplete="off"></asp:TextBox>

          </div>
          <div class="field-wrap">
              <label>
                  Lien de télechargement<span class="req">*</span>
              </label>
                    <asp:TextBox ID="tblien" runat="server" required="true" autocomplete="off"></asp:TextBox>
          </div>

                <asp:Button ID="BtnEnregistrer" runat="server" Text="S'enregistrer" class="button button-block" OnClick="BtnEnregistrer_Click" />


              <br />
              <br />
          <div class="field-wrap">
              <label>
                  Afin que vous puissiez être rémunéré vous devez créer un compte <asp:HyperLink ID="LinkToPaypall" runat="server">paypall</asp:HyperLink>
                  puis entrer votre numéro de compte ici.
              </label>
          </div>
              <br />
              <br />
              <br />
          <div class="field-wrap">
              <label>
                  Le lien de télechargement est l'adresse de la page web sur laquelle les utilisateurs pourront écouter et télécharger
                  votre musique. Pour cela nous vous conseillons de vous créer un compte sur <asp:HyperLink ID="LinkToReverbnation" runat="server">ReverbNation</asp:HyperLink>
                  ou tout autre site qui propose ce service.
              </label>
          </div>
              <br />
              <br />
              <br />
              <br />
              <br />
          <p class="forgot"><a href="Accueil.aspx">Retour à la page d'accueil</a></p>

              <br />
                        
          </form>

        </div>
        
        <div id="login">   
          <h1>Welcome Back!</h1>
          
          <form action="Home.aspx" method="post" >
          
            <div class="field-wrap">
            <label>
              Adresse mail<span class="req">*</span>
            </label>
            <input type="email"required autocomplete="off"/>
          </div>
          
          <div class="field-wrap">
            <label>
              Mot de passe<span class="req">*</span>
            </label>
            <input type="password"required autocomplete="off"/>
          </div>
          
          <p class="forgot"><a href="#">Mot de passe oublié?</a></p>
          
          <button class="button button-block"/>Connection</button>
          <br />
              <br />
          <p class="forgot"><a href="Accueil.aspx">RETOUR A LA PAGE D'ACCUEIL</a></p>

          </form>

        </div>
        
      </div><!-- tab-content -->
      
</div> <!-- /form -->
  <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    <script src="Scripts/scripts/index.js"></script>

</body>
</html>
