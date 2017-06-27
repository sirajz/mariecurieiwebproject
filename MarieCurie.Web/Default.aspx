<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MarieCurie.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <script type ="text/javascript">
        //$(document).ready(function () {
            
        //    $('open').parent('div').addClass('panel panel-warning col-md-4');
        //    $('close').parent('div').addClass('panel panel-default col-md-4');

        //});
    </script>

        <div class="container">
            <h1>Marie Curie Helper service</h1>
			<p class="lead">We know the little things can make a big difference when you, or someone you care about, are living with a terminal illness.</p>
			<h2>Find a Marie Curie Helper</h2>
			<p>Having someone to chat to over a cup of tea, help you get to an appointment or run an errand, or just be there to listen when you need a friendly ear.</p>
			
			<!-- OUTPUT HELPER SERVICES DETAILS HERE -->
			<!-- Use Panel module for each helper service -->
			<!-- With class  .panel-default if the Helper Service is closed -->
			<!-- With class .panel-warning if the Helper Service is open -->


            <div>
                <% foreach (var center in getHelperServices())
                        { %>            
       

                            <div class="<%= getStyle(center) %>">
                            
                                <div class="panel-heading">
                                    <h3 class="panel-title"><a href="https://www.mariecurie.org.uk/help/helper-volunteers"> <%: center.Title %></a></h3>
                                </div>
                            
                                <div class="panel-body ">
                                    <p><%: center.Description %></p>
                                    <p><a href="tel:<%: center.TelephoneNumber %>"><%: center.TelephoneNumber %></a>
                                </div>
                            
                                <div class="panel-footer">
                                    <p> <%= getNextOpenning(center)  %></p>
                                </div>

                            </div> 

                         <% } //foreach %>

            </div>	
 
                                			
		</div>


</asp:Content>
