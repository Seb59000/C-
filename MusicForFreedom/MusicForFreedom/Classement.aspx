<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Classement.aspx.cs" Inherits="MusicForFreedom.Classement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    
        <div id="menu-accordeon">
        
            <div class="main_column_section">       
            
                <h2><span></span>Une nouvelle façon d'écouter la musique<span></span></h2>
                
                <div class="main_column_section_content">
                
                  
                  <div>
                      <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1">
                      </asp:GridView>
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                  </div>
                  </div>
              <div class="cleaner"></div>
                <div class="bottom"></div>
            </div>
            
            <div class="main_column_section">       
            
                <h2><span></span>Artistes Comment  créer votre page?<span></span></h2>
                
                <div class="main_column_section_content">
                
					<a href="connexion artistes"><img class="image_wrapper fl_image" src="images/mic.jpg" alt="image two" /></a>               
                    <p> Il vous suffit de vous connecter en tant qu'artiste dans la section connexion. </p>
                    <p>Une fois votre profil créé suivez les instructions.</p>
                    <p>Nous travaillons en partenariat avec plusieurs sites afin de vous apporter un service gratuit et direct.</p>
                    <p>Mais pour cela il va falloir...</p>
            <div class="cleaner_h20"></div> 
                       
                    <ul class="list_01">
                        <li>Créer un compte Paypal afin de récolter vos dons.</li>
                        <li>Créer une page sur reverbnation afin de diffuser votre musique</li>
                      <li>Y télécharger toutes les compositions que vous souhaiter partager.</li>
                      <li>En auoriser le streaming et le téléchargement.                    </li>
                  </ul>
                    <div class="button_01"></div>    
                
                </div>
            <div class="bottom"></div>
            </div>
        
        	
            <div class="cleaner"></div>
        </div> <!-- end of main column -->

</asp:Content>
