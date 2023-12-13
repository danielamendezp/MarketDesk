<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<!-- Plantilla para el elemento principal 'MarketDesk' -->
	<xsl:template match="/MarketDesk">
		<html>
			<head>
				<title>Factura</title>
				<style>
					table {
					border-collapse: collapse;
					width: 100%;
					}
					th, td {
					border: 1px solid black;
					padding: 8px;
					text-align: left;
					}
				</style>
			</head>
			<body>
				<h1>Datos de Facturación</h1>
				<table>
					<tr>
						<th>Número de Factura</th>
						<th>Fecha de Emisión</th>
					</tr>
					<tr>
						<td>
							<xsl:value-of select="DatosFacturacion/@NumeroFactura"/>
						</td>
						<td>
							<xsl:value-of select="DatosFacturacion/@FechaEmision"/>
						</td>
					</tr>
				</table>

				<h2>Negocio</h2>
				<table>
					<tr>
						<th>Nombre</th>
						<th>Cédula Jurídica</th>
					</tr>
					<tr>
						<td>
							<xsl:value-of select="Negocio/@Negocio"/>
						</td>
						<td>
							<xsl:value-of select="Negocio/@CedulaJuridica"/>
						</td>
					</tr>
				</table>

				<h2>Cliente</h2>
				<table>
					<tr>
						<th>Nombre</th>
						<th>Identificación</th>
						<th>Email</th>
						<th>Número de Teléfono</th>
					</tr>
					<tr>
						<td>
							<xsl:value-of select="Cliente/@Nombre"/>
						</td>
						<td>
							<xsl:value-of select="Cliente/@Identificación"/>
						</td>
						<td>
							<xsl:value-of select="Cliente/@Email"/>
						</td>
						<td>
							<xsl:value-of select="Cliente/@Celular"/>
						</td>
					</tr>
				</table>

				<h2>Productos</h2>
				<table>
					<tr>
						<th>Producto</th>
						<th>Cantidad</th>
						<th>Precio Unitario</th>
						<th>Precio Total</th>
					</tr>
					<xsl:for-each select="Productos/Producto">
						<tr>
							<td>
								<xsl:value-of select="@Producto"/>
							</td>
							<td>
								<xsl:value-of select="@Cantidad"/>
							</td>
							<td>
								<xsl:value-of select="@PrecioUnitario"/>
							</td>
							<td>
								<xsl:value-of select="@PrecioTotal"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>

				<h2>Promociones</h2>
				<ul>
					<xsl:for-each select="Productos/Promociones">
						<li>
							<xsl:value-of select="."/>
						</li>
					</xsl:for-each>
				</ul>

				<h2>Detalles Financieros</h2>
				<table>
					<tr>
						<th>Subtotal</th>
						<th>Impuestos</th>
						<th>Descuentos</th>
						<th>Total</th>
					</tr>
					<tr>
						<td>
							<xsl:value-of select="Productos/SubTotal"/>
						</td>
						<td>
							<xsl:value-of select="Productos/Impuestos"/>
						</td>
						<td>
							<xsl:value-of select="Productos/Descuentos"/>
						</td>
						<td>
							<xsl:value-of select="Productos/Total"/>
						</td>
					</tr>
				</table>

			</body>
		</html>
	</xsl:template>

</xsl:stylesheet>

