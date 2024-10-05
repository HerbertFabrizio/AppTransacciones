using System.Net.Http.Headers;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Mvc;

@model IEnumerable<AppTransacciones.Models.>

@{
    ViewData["Title"]= "Listar Transacciones";
}
<h1>@ViewData["Title"]</h1>

<div class="container mt-5">
    <h2 class="mb-4"> Listado de transacciones internacionales</h2>
    <table class="table table-striped">
        <thead>
            <tr>
                <th></th>
            </tr>
        </thead>
        <tbody>
            @foreach (var transaccion in model)
            {
                <tr>
                    <td></td>
                </tr>
            }        
        </tbody>
    </table>
</div>