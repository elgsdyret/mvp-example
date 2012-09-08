<%@ Page Language="C#" AutoEventWireup="true" Inherits="MVPExample.DogSearchView" %>

<!DOCTYPE html>

<html>
	<head>
		<title>Search for your favorite dog</title>
	</head>
	<body>
		<form id="HtmlForm" runat="server">
			<div>
				<input type="text" id="SearchField" runat="server"/>
				<button type="button" id="SearchButton" runat="server" OnServerClick="SearchClick">Search/Filter</button>
			</div>
		</form>
		<div>
			<table>
				<tr><th>Name</th><th>Race</th></tr>
			<%foreach(var dog in Dogs)
			  { %>
				<tr><td><%=dog.Name%></td><td><%=dog.Race%></td></tr>			
			<% } %>
			</table>
		</div>
	</body>
</html>
