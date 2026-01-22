using PruebaMudBlazor2.Shared.Models;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PruebaMudBlazor2.Data;

public partial class SindicatoContext : DbContext
{
    public SindicatoContext()
    {
    }

    public SindicatoContext(DbContextOptions<SindicatoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Acta> Actas { get; set; }

    public virtual DbSet<ActaInspector> ActaInspectors { get; set; }

    public virtual DbSet<ActasCruzar> ActasCruzars { get; set; }

    public virtual DbSet<ActasDetalle> ActasDetalles { get; set; }

    public virtual DbSet<ActasDetalle1> ActasDetalles1 { get; set; }

    public virtual DbSet<Actividad> Actividads { get; set; }

    public virtual DbSet<Actum> Acta { get; set; }

    public virtual DbSet<Actum1> Acta1 { get; set; }

    public virtual DbSet<Actum2> Acta2 { get; set; }

    public virtual DbSet<Articulo> Articulos { get; set; }

    public virtual DbSet<Articulo1> Articulos1 { get; set; }

    public virtual DbSet<ArticuloAsignacion> ArticuloAsignacions { get; set; }

    public virtual DbSet<ArticuloDeposito> ArticuloDepositos { get; set; }

    public virtual DbSet<Articulos2024> Articulos2024s { get; set; }

    public virtual DbSet<ArticulosMov> ArticulosMovs { get; set; }

    public virtual DbSet<ArticulosPrecio> ArticulosPrecios { get; set; }

    public virtual DbSet<ArticulosXx> ArticulosXxes { get; set; }

    public virtual DbSet<Asignacione> Asignaciones { get; set; }

    public virtual DbSet<AsignarCobranza> AsignarCobranzas { get; set; }

    public virtual DbSet<Aviso> Avisos { get; set; }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Caja> Cajas { get; set; }

    public virtual DbSet<CajaStock> CajaStocks { get; set; }

    public virtual DbSet<Cajas2024> Cajas2024s { get; set; }

    public virtual DbSet<Campeonato> Campeonatos { get; set; }

    public virtual DbSet<Campequipo> Campequipos { get; set; }

    public virtual DbSet<Cancha> Canchas { get; set; }

    public virtual DbSet<Canje> Canjes { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<CategoriasEmpleado> CategoriasEmpleados { get; set; }

    public virtual DbSet<Cheque> Cheques { get; set; }

    public virtual DbSet<Cobradore> Cobradores { get; set; }

    public virtual DbSet<Cobro> Cobros { get; set; }

    public virtual DbSet<CobrosDetalle> CobrosDetalles { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Comentario> Comentarios { get; set; }

    public virtual DbSet<Comprobante> Comprobantes { get; set; }

    public virtual DbSet<Control> Controls { get; set; }

    public virtual DbSet<CuponArt> CuponArts { get; set; }

    public virtual DbSet<CuponBenefArticulo> CuponBenefArticulos { get; set; }

    public virtual DbSet<Ddjj> Ddjjs { get; set; }

    public virtual DbSet<Ddjj1> Ddjjs1 { get; set; }

    public virtual DbSet<Ddjjt> Ddjjts { get; set; }

    public virtual DbSet<Ddjjt1> Ddjjts1 { get; set; }

    public virtual DbSet<Deposito> Depositos { get; set; }

    public virtual DbSet<DetalleCanje> DetalleCanjes { get; set; }

    public virtual DbSet<DetalleTipoPago> DetalleTipoPagos { get; set; }

    public virtual DbSet<Efectivo> Efectivos { get; set; }

    public virtual DbSet<EmailsCredenciale> EmailsCredenciales { get; set; }

    public virtual DbSet<EntregasMochila> EntregasMochilas { get; set; }

    public virtual DbSet<Equipo> Equipos { get; set; }

    public virtual DbSet<EquipoEscudo> EquipoEscudos { get; set; }

    public virtual DbSet<EscalaSalarial> EscalaSalarials { get; set; }

    public virtual DbSet<EstudioContableEmpresa> EstudioContableEmpresas { get; set; }

    public virtual DbSet<EstudiosContable> EstudiosContables { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<EventosArt> EventosArts { get; set; }

    public virtual DbSet<EventosArtAsig> EventosArtAsigs { get; set; }

    public virtual DbSet<EventosAño> EventosAños { get; set; }

    public virtual DbSet<EventosCupone> EventosCupones { get; set; }

    public virtual DbSet<EventosCupone1> EventosCupones1 { get; set; }

    public virtual DbSet<EventosCupone2> EventosCupones2 { get; set; }

    public virtual DbSet<EventosCupone3> EventosCupones3 { get; set; }

    public virtual DbSet<EventosExep> EventosExeps { get; set; }

    public virtual DbSet<Fase> Fases { get; set; }

    public virtual DbSet<Filial> Filials { get; set; }

    public virtual DbSet<FormaDePago> FormaDePagos { get; set; }

    public virtual DbSet<Foto> Fotos { get; set; }

    public virtual DbSet<Grupo> Grupos { get; set; }

    public virtual DbSet<ImpresionActa> ImpresionActas { get; set; }

    public virtual DbSet<ImpresionComprobante> ImpresionComprobantes { get; set; }

    public virtual DbSet<Inspectore> Inspectores { get; set; }

    public virtual DbSet<InspectoresAsignacionEmpresa> InspectoresAsignacionEmpresas { get; set; }

    public virtual DbSet<Interese> Intereses { get; set; }

    public virtual DbSet<Interese1> Intereses1 { get; set; }

    public virtual DbSet<Juece> Jueces { get; set; }

    public virtual DbSet<JugadorGol> JugadorGols { get; set; }

    public virtual DbSet<JugadorTarjetum> JugadorTarjeta { get; set; }

    public virtual DbSet<Jugadore> Jugadores { get; set; }

    public virtual DbSet<JugadoresExepcione> JugadoresExepciones { get; set; }

    public virtual DbSet<Liga> Ligas { get; set; }

    public virtual DbSet<Localidad> Localidads { get; set; }

    public virtual DbSet<Localidade> Localidades { get; set; }

    public virtual DbSet<Maeemp> Maeemps { get; set; }

    public virtual DbSet<Maeflium> Maeflia { get; set; }

    public virtual DbSet<Maesoc> Maesocs { get; set; }

    public virtual DbSet<Marca> Marcas { get; set; }

    public virtual DbSet<Marca1> Marcas1 { get; set; }

    public virtual DbSet<Novedade> Novedades { get; set; }

    public virtual DbSet<Objeto> Objetos { get; set; }

    public virtual DbSet<Obrasocial> Obrasocials { get; set; }

    public virtual DbSet<ParaInspeccion> ParaInspeccions { get; set; }

    public virtual DbSet<Parentesco> Parentescos { get; set; }

    public virtual DbSet<Parjugcamisetum> Parjugcamiseta { get; set; }

    public virtual DbSet<Partido> Partidos { get; set; }

    public virtual DbSet<Partidos2023> Partidos2023s { get; set; }

    public virtual DbSet<PartidosCambio> PartidosCambios { get; set; }

    public virtual DbSet<PartidosJuece> PartidosJueces { get; set; }

    public virtual DbSet<PartidosTarjeta> PartidosTarjetas { get; set; }

    public virtual DbSet<Permiso> Permisos { get; set; }

    public virtual DbSet<PlanDetalle> PlanDetalles { get; set; }

    public virtual DbSet<PlanesDePago> PlanesDePagos { get; set; }

    public virtual DbSet<Premio> Premios { get; set; }

    public virtual DbSet<PremiosSorteo> PremiosSorteos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    public virtual DbSet<Provincia> Provincias { get; set; }

    public virtual DbSet<Quincho> Quinchos { get; set; }

    public virtual DbSet<Ranking> Rankings { get; set; }

    public virtual DbSet<Recibo> Recibos { get; set; }

    public virtual DbSet<RecibosDetalle> RecibosDetalles { get; set; }

    public virtual DbSet<ReservasQuincho> ReservasQuinchos { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<RolesControl> RolesControls { get; set; }

    public virtual DbSet<Rubro> Rubros { get; set; }

    public virtual DbSet<Rubro1> Rubros1 { get; set; }

    public virtual DbSet<SancionFecha> SancionFechas { get; set; }

    public virtual DbSet<Sancione> Sanciones { get; set; }

    public virtual DbSet<SancionesAnt> SancionesAnts { get; set; }

    public virtual DbSet<SecuenciaPeriodo> SecuenciaPeriodos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Sexo> Sexos { get; set; }

    public virtual DbSet<Soccen> Soccens { get; set; }

    public virtual DbSet<Socemp> Socemps { get; set; }

    public virtual DbSet<Socflium> Socflia { get; set; }

    public virtual DbSet<Sorteo> Sorteos { get; set; }

    public virtual DbSet<SorteosGanadore> SorteosGanadores { get; set; }

    public virtual DbSet<SubRubro> SubRubros { get; set; }

    public virtual DbSet<SubRubro1> SubRubros1 { get; set; }

    public virtual DbSet<Tarjeta> Tarjetas { get; set; }

    public virtual DbSet<TipoComprobante> TipoComprobantes { get; set; }

    public virtual DbSet<TipoComprobanteLetra> TipoComprobanteLetras { get; set; }

    public virtual DbSet<TipoDePago> TipoDePagos { get; set; }

    public virtual DbSet<TipoDeRecibo> TipoDeRecibos { get; set; }

    public virtual DbSet<Transferencia> Transferencias { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    public virtual DbSet<UsuariosObjeto> UsuariosObjetos { get; set; }

    public virtual DbSet<VdCabecera> VdCabeceras { get; set; }

    public virtual DbSet<VdCabecera1> VdCabeceras1 { get; set; }

    public virtual DbSet<VdDetalle> VdDetalles { get; set; }

    public virtual DbSet<VdDetalle1> VdDetalles1 { get; set; }

    public virtual DbSet<VdInspector> VdInspectors { get; set; }

    public virtual DbSet<VdInspector1> VdInspectors1 { get; set; }

    public virtual DbSet<VdPlanesDePago> VdPlanesDePagos { get; set; }

    public virtual DbSet<VdPlanesDePagoDetalle> VdPlanesDePagoDetalles { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    public virtual DbSet<VentasDetalle> VentasDetalles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    //modelBuilder.HasDbFunction(typeof(Services.FuncUtiles).GetMethod("CalcularEdad"))
    //.HasName("dbo.CalcularEdad"); // Nombre de la funci�n en la base de datos

    modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<Acta>(entity =>
        {
            entity.HasKey(e => e.IdActa).HasName("PK_ACTAS_7");

            entity.ToTable("ACTAS_");

            entity.Property(e => e.IdActa).HasColumnName("ID_ACTA");
            entity.Property(e => e.Acta1).HasColumnName("ACTA");
            entity.Property(e => e.Adevengar)
                .HasMaxLength(255)
                .HasColumnName("ADEVENGAR");
            entity.Property(e => e.Anticipo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ANTICIPO");
            entity.Property(e => e.AsigDesde)
                .HasColumnType("datetime")
                .HasColumnName("ASIG_DESDE");
            entity.Property(e => e.AsigDeudaAprox)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ASIG_DEUDA_APROX");
            entity.Property(e => e.AsigHasta)
                .HasColumnType("datetime")
                .HasColumnName("ASIG_HASTA");
            entity.Property(e => e.Año).HasColumnName("A�O");
            entity.Property(e => e.Cantidadcuotas).HasColumnName("CANTIDADCUOTAS");
            entity.Property(e => e.Cobradototalmente)
                .HasMaxLength(255)
                .HasColumnName("COBRADOTOTALMENTE");
            entity.Property(e => e.Coeficiente)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("COEFICIENTE");
            entity.Property(e => e.Cuit).HasColumnName("CUIT");
            entity.Property(e => e.CuitStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIT_STR");
            entity.Property(e => e.Cuotasdevengadas).HasColumnName("CUOTASDEVENGADAS");
            entity.Property(e => e.Desde)
                .HasColumnType("datetime")
                .HasColumnName("DESDE");
            entity.Property(e => e.Deudaactualizada).HasColumnName("DEUDAACTUALIZADA");
            entity.Property(e => e.Deudahistorica).HasColumnName("DEUDAHISTORICA");
            entity.Property(e => e.Deudatotal).HasColumnName("DEUDATOTAL");
            entity.Property(e => e.Devengado)
                .HasMaxLength(255)
                .HasColumnName("DEVENGADO");
            entity.Property(e => e.Dias).HasColumnName("DIAS");
            entity.Property(e => e.Diferencia).HasColumnName("DIFERENCIA");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(255)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.Ejercicio).HasColumnName("EJERCICIO");
            entity.Property(e => e.Empresa)
                .HasMaxLength(255)
                .HasColumnName("EMPRESA");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.EstudioInspector).HasColumnName("ESTUDIO_INSPECTOR");
            entity.Property(e => e.EstudioJuridico).HasColumnName("ESTUDIO_JURIDICO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.FechaAsig)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ASIG");
            entity.Property(e => e.FechaAsigAnterior)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ASIG_ANTERIOR");
            entity.Property(e => e.FechaVencActa)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_VENC_ACTA");
            entity.Property(e => e.Financiacion).HasColumnName("FINANCIACION");
            entity.Property(e => e.Hasta)
                .HasColumnType("datetime")
                .HasColumnName("HASTA");
            entity.Property(e => e.ImporteCuota)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("IMPORTE_CUOTA");
            entity.Property(e => e.Importecobrado).HasColumnName("IMPORTECOBRADO");
            entity.Property(e => e.Inspector)
                .HasMaxLength(255)
                .HasColumnName("INSPECTOR");
            entity.Property(e => e.InspectorAnterior)
                .HasMaxLength(50)
                .HasColumnName("INSPECTOR_ANTERIOR");
            entity.Property(e => e.InspectorId).HasDefaultValue(0);
            entity.Property(e => e.Intereses).HasColumnName("INTERESES");
            entity.Property(e => e.Interesfinanc).HasColumnName("INTERESFINANC");
            entity.Property(e => e.MontoCertif)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MONTO_CERTIF");
            entity.Property(e => e.MontoCertifActa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("MONTO_CERTIF_ACTA");
            entity.Property(e => e.NumCertif)
                .HasMaxLength(255)
                .HasColumnName("NUM_CERTIF");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("OBSERVACIONES");
            entity.Property(e => e.Tasa)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("TASA");
            entity.Property(e => e.Total)
                .HasMaxLength(255)
                .HasColumnName("TOTAL");
        });

        modelBuilder.Entity<ActaInspector>(entity =>
        {
            entity.ToTable("acta_inspector");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acta).HasColumnName("ACTA");
            entity.Property(e => e.IdactaInspector).HasColumnName("IDACTA_INSPECTOR");
            entity.Property(e => e.Inspector).HasColumnName("INSPECTOR");
        });

        modelBuilder.Entity<ActasCruzar>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("actas_cruzar");

            entity.Property(e => e.CobradoTotalmente)
                .HasMaxLength(255)
                .HasColumnName("COBRADO_TOTALMENTE");
            entity.Property(e => e.Cuit).HasColumnName("CUIT");
            entity.Property(e => e.Desde)
                .HasColumnType("datetime")
                .HasColumnName("DESDE");
            entity.Property(e => e.DeudaActualizada).HasColumnName("DEUDA_ACTUALIZADA");
            entity.Property(e => e.DeudaHistorica).HasColumnName("DEUDA_HISTORICA");
            entity.Property(e => e.DeudaTotal).HasColumnName("DEUDA_TOTAL");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(255)
                .HasColumnName("DOMICILIO");
            entity.Property(e => e.Empresa)
                .HasMaxLength(255)
                .HasColumnName("EMPRESA");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Hasta)
                .HasColumnType("datetime")
                .HasColumnName("HASTA");
            entity.Property(e => e.Inspector)
                .HasMaxLength(255)
                .HasColumnName("INSPECTOR");
            entity.Property(e => e.Intereses).HasColumnName("INTERESES");
            entity.Property(e => e.InteresesDeFinanciacion).HasColumnName("INTERESES_DE_FINANCIACION");
            entity.Property(e => e.NroActa).HasColumnName("NRO_ACTA");
            entity.Property(e => e.Observaciones)
                .HasMaxLength(255)
                .HasColumnName("OBSERVACIONES");
        });

        modelBuilder.Entity<ActasDetalle>(entity =>
        {
            entity.ToTable("ActasDetalle");

            entity.Property(e => e.DeudaGenerada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteDepositado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresGenerado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteSocios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoSocios).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ActasDetalle1>(entity =>
        {
            entity.ToTable("ActasDetalle_");

            entity.Property(e => e.DeudaGenerada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ImporteDepositado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresGenerado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteSocios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoSocios).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Actividad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("actividad");

            entity.Property(e => e.MaeactCodact).HasColumnName("MAEACT_CODACT");
            entity.Property(e => e.MaeactNomact)
                .HasMaxLength(255)
                .HasColumnName("MAEACT_NOMACT");
        });

        modelBuilder.Entity<Actum>(entity =>
        {
            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiarioAplicado).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.InteresMensualAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaviones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Actum1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Acta_");

            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiarioAplicado).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.InteresMensualAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Actum2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Actas");

            entity.ToTable("Acta___");

            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiarioAplicado).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.InteresMensualAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Articulo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_articulos_2");

            entity.ToTable("articulos");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodigoDeBarra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).HasMaxLength(200);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
        });

        modelBuilder.Entity<Articulo1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_articulos_1");

            entity.ToTable("articulos_");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodigoDeBarra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CodigoDelProveedor)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Sexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ArticuloAsignacion>(entity =>
        {
            entity.ToTable("ArticuloAsignacion");

            entity.Property(e => e.ReservaNumero).HasColumnName("Reserva_Numero");
            entity.Property(e => e.ReservaQuinchoId).HasColumnName("Reserva_QuinchoId");
        });

        modelBuilder.Entity<ArticuloDeposito>(entity =>
        {
            entity.ToTable("ArticuloDeposito");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<Articulos2024>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("articulos_2024");

            entity.Property(e => e.CodigoDeBarra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).HasMaxLength(100);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<ArticulosMov>(entity =>
        {
            entity.Property(e => e.Cantidad).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Egreso).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Ingreso).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ArticulosPrecio>(entity =>
        {
            entity.ToTable("ArticulosPrecio");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.PrecioCosto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PrecioVenta).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<ArticulosXx>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_articulos");

            entity.ToTable("articulos_xx");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CodigoDeBarra)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Comentario).HasMaxLength(200);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
        });

        modelBuilder.Entity<Asignacione>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Numero).HasDefaultValue(0);
        });

        modelBuilder.Entity<AsignarCobranza>(entity =>
        {
            entity.ToTable("AsignarCobranza");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CobradorId).HasColumnName("CobradorID");
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
        });

        modelBuilder.Entity<Aviso>(entity =>
        {
            entity.HasKey(e => e.IdAviso).HasName("PK_AVISOS");

            entity.ToTable("avisos");

            entity.Property(e => e.IdAviso).HasColumnName("ID_AVISO");
            entity.Property(e => e.FechaGenAviso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_GEN_AVISO");
            entity.Property(e => e.IdActa).HasColumnName("ID_ACTA");
            entity.Property(e => e.NroAviso).HasColumnName("NRO_AVISO");
        });

        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Bancos_1");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BanBantId).HasColumnName("BAN_BANT_ID");
            entity.Property(e => e.BanContacto)
                .HasMaxLength(255)
                .HasColumnName("BAN_CONTACTO");
            entity.Property(e => e.BanDireccion)
                .HasMaxLength(255)
                .HasColumnName("BAN_DIRECCION");
            entity.Property(e => e.BanId).HasColumnName("BAN_ID");
            entity.Property(e => e.BanNombre)
                .HasMaxLength(255)
                .HasColumnName("BAN_NOMBRE");
            entity.Property(e => e.BanNro).HasColumnName("BAN_NRO");
            entity.Property(e => e.BanObs)
                .HasMaxLength(255)
                .HasColumnName("BAN_OBS");
            entity.Property(e => e.BanSucId).HasColumnName("BAN_SUC_ID");
            entity.Property(e => e.BanSucursal)
                .HasMaxLength(255)
                .HasColumnName("BAN_SUCURSAL");
            entity.Property(e => e.BanTelefono)
                .HasMaxLength(255)
                .HasColumnName("BAN_TELEFONO");
        });

        modelBuilder.Entity<Caja>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cajas_1");

            entity.Property(e => e.CargaCheque).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargaCuentaCorriente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargaEfectivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargaTarjeta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CargaTransferencia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FaltanteCheque).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FaltanteCuentaCorriente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FaltanteEfectivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FaltanteTarjeta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FaltanteTransferencia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaApertura).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.MontoApertura).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoCheque).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoCuentaCorriente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoEfectivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTarjeta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTotal).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MontoTransferecia).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SobranteCheque).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SobranteCuentaCorriente).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SobranteEfectivo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SobranteTarjeta).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SobranteTransferencia).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<CajaStock>(entity =>
        {
            entity.ToTable("CajaStock");

            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
        });

        modelBuilder.Entity<Cajas2024>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cajas");

            entity.ToTable("Cajas_2024");

            entity.Property(e => e.FechaApertura).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
        });

        modelBuilder.Entity<Campeonato>(entity =>
        {
            entity.HasKey(e => e.Campid);

            entity.ToTable("campeonatos");

            entity.Property(e => e.Campid).HasColumnName("CAMPID");
            entity.Property(e => e.CampLigaid).HasColumnName("CAMP_LIGAID");
            entity.Property(e => e.Campaño).HasColumnName("CAMPA�O");
            entity.Property(e => e.Campestado).HasColumnName("CAMPESTADO");
            entity.Property(e => e.Campnombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CAMPNOMBRE");
            entity.Property(e => e.Camptemporada)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CAMPTEMPORADA");
        });

        modelBuilder.Entity<Campequipo>(entity =>
        {
            entity.ToTable("campequipo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CampCampid).HasColumnName("CAMP_CAMPID");
            entity.Property(e => e.CampEquipoid1).HasColumnName("CAMP_EQUIPOID");
            entity.Property(e => e.CampEquipoidIdsorteo).HasColumnName("CAMP_EQUIPOID_IDSORTEO");
            entity.Property(e => e.Campequipoid).HasColumnName("CAMPEQUIPOID");
        });

        modelBuilder.Entity<Cancha>(entity =>
        {
            entity.ToTable("canchas");

            entity.Property(e => e.Canchaid).HasColumnName("CANCHAID");
            entity.Property(e => e.Canchanombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CANCHANOMBRE");
        });

        modelBuilder.Entity<Canje>(entity =>
        {
            entity.ToTable("canjes");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.FechaFactura).HasColumnType("datetime");
            entity.Property(e => e.FechaRemito).HasColumnType("datetime");
            entity.Property(e => e.ImporteFactura).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.Catid);

            entity.ToTable("categorias");

            entity.Property(e => e.Catid).HasColumnName("CATID");
            entity.Property(e => e.Catedadlimite).HasColumnName("CATEDADLIMITE");
            entity.Property(e => e.Catestado).HasColumnName("CATESTADO");
            entity.Property(e => e.Catnombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CATNOMBRE");
        });

        modelBuilder.Entity<CategoriasEmpleado>(entity =>
        {
            entity.ToTable("categorias_empleado");

            entity.Property(e => e.MaecatCodcat).HasColumnName("MAECAT_CODCAT");
            entity.Property(e => e.MaecatNomcat)
                .HasMaxLength(255)
                .HasColumnName("MAECAT_NOMCAT");
        });

        modelBuilder.Entity<Cheque>(entity =>
        {
            entity.ToTable("cheques");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BancoId).HasColumnName("BancoID");
            entity.Property(e => e.Cuit)
                .HasMaxLength(12)
                .HasColumnName("CUIT");
            entity.Property(e => e.Emisor).HasMaxLength(50);
            entity.Property(e => e.Estado).HasDefaultValue(1);
            entity.Property(e => e.FechaDeEmision).HasColumnType("datetime");
            entity.Property(e => e.FechaDePresentacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDeVencimiento).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(13, 2)");
            entity.Property(e => e.NroDeCheque).HasMaxLength(20);
            entity.Property(e => e.NroDeCuenta).HasMaxLength(20);
            entity.Property(e => e.NroDeOperacion).HasMaxLength(20);
            entity.Property(e => e.NroDeTransferencia).HasMaxLength(20);
        });

        modelBuilder.Entity<Cobradore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Cobrador");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Apellido)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Estado).HasDefaultValue(1);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Cobro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_COBROS_");

            entity.ToTable("COBROS");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acta).HasColumnName("ACTA");
            entity.Property(e => e.CantidadCuotas)
                .HasMaxLength(255)
                .HasColumnName("CANTIDAD_CUOTAS");
            entity.Property(e => e.Cheque).HasColumnName("CHEQUE");
            entity.Property(e => e.Concepto)
                .HasMaxLength(255)
                .HasColumnName("CONCEPTO");
            entity.Property(e => e.Cuit).HasColumnName("CUIT");
            entity.Property(e => e.Cuotas)
                .HasMaxLength(255)
                .HasColumnName("CUOTAS");
            entity.Property(e => e.Cuotax)
                .HasMaxLength(255)
                .HasColumnName("CUOTAX");
            entity.Property(e => e.Desconocido)
                .HasMaxLength(255)
                .HasColumnName("DESCONOCIDO");
            entity.Property(e => e.DiasAtraso)
                .HasMaxLength(255)
                .HasColumnName("DIAS_ATRASO");
            entity.Property(e => e.Empresa)
                .HasMaxLength(255)
                .HasColumnName("EMPRESA");
            entity.Property(e => e.FechaVenc)
                .HasMaxLength(255)
                .HasColumnName("FECHA_VENC");
            entity.Property(e => e.Fecharecaudacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHARECAUDACION");
            entity.Property(e => e.Importe).HasColumnName("IMPORTE");
            entity.Property(e => e.Importecheque).HasColumnName("IMPORTECHEQUE");
            entity.Property(e => e.Importemercaderia).HasColumnName("IMPORTEMERCADERIA");
            entity.Property(e => e.Inspector)
                .HasMaxLength(255)
                .HasColumnName("INSPECTOR");
            entity.Property(e => e.Interes)
                .HasMaxLength(255)
                .HasColumnName("INTERES");
            entity.Property(e => e.Mercaderias).HasColumnName("MERCADERIAS");
            entity.Property(e => e.Mes)
                .HasColumnType("datetime")
                .HasColumnName("MES");
            entity.Property(e => e.Recibo).HasColumnName("RECIBO");
            entity.Property(e => e.Total).HasColumnName("TOTAL");
        });

        modelBuilder.Entity<CobrosDetalle>(entity =>
        {
            entity.ToTable("cobros_detalle");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CobrosId).HasColumnName("CobrosID");
            entity.Property(e => e.Estado).HasComment("1 -Efectivo / 2 - Cheque  / 3 - Canje");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoDePagoId).HasColumnName("TipoDePagoID");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
        });

        modelBuilder.Entity<Colore>(entity =>
        {
            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Comentario>(entity =>
        {
            entity.ToTable("comentarios");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Comentario1)
                .HasMaxLength(300)
                .IsUnicode(false)
                .HasColumnName("COMENTARIO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.IdUsuario).HasColumnName("ID_USUARIO");
            entity.Property(e => e.PcId).HasColumnName("PC_ID");
            entity.Property(e => e.PiId).HasColumnName("PI_ID");
        });

        modelBuilder.Entity<Comprobante>(entity =>
        {
            entity.Property(e => e.Importe).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Control>(entity =>
        {
            entity.HasKey(e => e.IdControls);

            entity.Property(e => e.Estado).HasDefaultValue(1);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CuponArt>(entity =>
        {
            entity.ToTable("cupon_art");

            entity.Property(e => e.CuponArtId).HasColumnName("cupon_art_id");
            entity.Property(e => e.CuponArtEntrega).HasColumnName("cupon_art_entrega");
            entity.Property(e => e.CuponArtEventArtId).HasColumnName("cupon_art_event_art_id");
            entity.Property(e => e.CuponArtEventCuponId).HasColumnName("cupon_art_event_cupon_id");
        });

        modelBuilder.Entity<CuponBenefArticulo>(entity =>
        {
            entity.Property(e => e.Cuil).HasMaxLength(50);
        });

        modelBuilder.Entity<Ddjj>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ddjj");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Cargaf).HasColumnName("cargaf");
            entity.Property(e => e.Cuil).HasColumnName("cuil");
            entity.Property(e => e.CuilStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIL_STR");
            entity.Property(e => e.CuitStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIT_STR");
            entity.Property(e => e.Cuite).HasColumnName("cuite");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Impo).HasColumnName("impo");
            entity.Property(e => e.Impoaux).HasColumnName("impoaux");
            entity.Property(e => e.Impom1).HasColumnName("impom1");
            entity.Property(e => e.Impp).HasColumnName("impp");
            entity.Property(e => e.Item1).HasColumnName("item1");
            entity.Property(e => e.Item2).HasColumnName("item2");
            entity.Property(e => e.Item3).HasColumnName("item3");
            entity.Property(e => e.Item4).HasColumnName("item4");
            entity.Property(e => e.Jorp).HasColumnName("jorp");
            entity.Property(e => e.Jub).HasColumnName("jub");
            entity.Property(e => e.Lic)
                .HasMaxLength(4)
                .HasColumnName("lic");
            entity.Property(e => e.Periodo)
                .HasColumnType("datetime")
                .HasColumnName("periodo");
            entity.Property(e => e.Rect).HasColumnName("rect");
        });

        modelBuilder.Entity<Ddjj1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ddjj_");

            entity.Property(e => e.Activo).HasColumnName("activo");
            entity.Property(e => e.Cargaf).HasColumnName("cargaf");
            entity.Property(e => e.Cuil).HasColumnName("cuil");
            entity.Property(e => e.CuilStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIL_STR");
            entity.Property(e => e.CuitStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIT_STR");
            entity.Property(e => e.Cuite).HasColumnName("cuite");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Impo).HasColumnName("impo");
            entity.Property(e => e.Impoaux).HasColumnName("impoaux");
            entity.Property(e => e.Impom1).HasColumnName("impom1");
            entity.Property(e => e.Impp).HasColumnName("impp");
            entity.Property(e => e.Item1).HasColumnName("item1");
            entity.Property(e => e.Item2).HasColumnName("item2");
            entity.Property(e => e.Item3).HasColumnName("item3");
            entity.Property(e => e.Item4).HasColumnName("item4");
            entity.Property(e => e.Jorp).HasColumnName("jorp");
            entity.Property(e => e.Jub).HasColumnName("jub");
            entity.Property(e => e.Lic)
                .HasMaxLength(4)
                .HasColumnName("lic");
            entity.Property(e => e.Periodo)
                .HasColumnType("datetime")
                .HasColumnName("periodo");
            entity.Property(e => e.Rect).HasColumnName("rect");
        });

        modelBuilder.Entity<Ddjjt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ddjjt");

            entity.Property(e => e.Acta).HasColumnName("acta");
            entity.Property(e => e.Ctrlimp).HasColumnName("ctrlimp");
            entity.Property(e => e.Ctrlleg).HasColumnName("ctrlleg");
            entity.Property(e => e.Cuit).HasColumnName("cuit");
            entity.Property(e => e.CuitStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIT_STR");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fmod)
                .HasColumnType("datetime")
                .HasColumnName("fmod");
            entity.Property(e => e.Fpago)
                .HasColumnType("datetime")
                .HasColumnName("fpago");
            entity.Property(e => e.Fpago2)
                .HasColumnType("datetime")
                .HasColumnName("fpago2");
            entity.Property(e => e.Fpago3)
                .HasColumnType("datetime")
                .HasColumnName("fpago3");
            entity.Property(e => e.Fpres)
                .HasColumnType("datetime")
                .HasColumnName("fpres");
            entity.Property(e => e.Fproc)
                .HasColumnType("datetime")
                .HasColumnName("fproc");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Impban1).HasColumnName("impban1");
            entity.Property(e => e.Impban2).HasColumnName("impban2");
            entity.Property(e => e.Impban3).HasColumnName("impban3");
            entity.Property(e => e.Impex1).HasColumnName("impex1");
            entity.Property(e => e.Impex2).HasColumnName("impex2");
            entity.Property(e => e.Impex3).HasColumnName("impex3");
            entity.Property(e => e.Medio1).HasColumnName("medio1");
            entity.Property(e => e.Medio2).HasColumnName("medio2");
            entity.Property(e => e.Medio3).HasColumnName("medio3");
            entity.Property(e => e.Nver)
                .HasMaxLength(6)
                .HasColumnName("nver");
            entity.Property(e => e.Periodo)
                .HasColumnType("datetime")
                .HasColumnName("periodo");
            entity.Property(e => e.Rect).HasColumnName("rect");
            entity.Property(e => e.Repite).HasColumnName("repite");
            entity.Property(e => e.Titem1).HasColumnName("titem1");
            entity.Property(e => e.Titem2).HasColumnName("titem2");
            entity.Property(e => e.Titem3).HasColumnName("titem3");
            entity.Property(e => e.Titem4).HasColumnName("titem4");
            entity.Property(e => e.Trans1).HasColumnName("trans1");
            entity.Property(e => e.Trans2).HasColumnName("trans2");
            entity.Property(e => e.Trans3).HasColumnName("trans3");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Ddjjt1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ddjjt_");

            entity.Property(e => e.Acta).HasColumnName("acta");
            entity.Property(e => e.Ctrlimp).HasColumnName("ctrlimp");
            entity.Property(e => e.Ctrlleg).HasColumnName("ctrlleg");
            entity.Property(e => e.Cuit).HasColumnName("cuit");
            entity.Property(e => e.CuitStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIT_STR");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.Fmod)
                .HasColumnType("datetime")
                .HasColumnName("fmod");
            entity.Property(e => e.Fpago)
                .HasColumnType("datetime")
                .HasColumnName("fpago");
            entity.Property(e => e.Fpago2)
                .HasColumnType("datetime")
                .HasColumnName("fpago2");
            entity.Property(e => e.Fpago3)
                .HasColumnType("datetime")
                .HasColumnName("fpago3");
            entity.Property(e => e.Fpres)
                .HasColumnType("datetime")
                .HasColumnName("fpres");
            entity.Property(e => e.Fproc)
                .HasColumnType("datetime")
                .HasColumnName("fproc");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Impban1).HasColumnName("impban1");
            entity.Property(e => e.Impban2).HasColumnName("impban2");
            entity.Property(e => e.Impban3).HasColumnName("impban3");
            entity.Property(e => e.Impex1).HasColumnName("impex1");
            entity.Property(e => e.Impex2).HasColumnName("impex2");
            entity.Property(e => e.Impex3).HasColumnName("impex3");
            entity.Property(e => e.Medio1).HasColumnName("medio1");
            entity.Property(e => e.Medio2).HasColumnName("medio2");
            entity.Property(e => e.Medio3).HasColumnName("medio3");
            entity.Property(e => e.Nver)
                .HasMaxLength(6)
                .HasColumnName("nver");
            entity.Property(e => e.Periodo)
                .HasColumnType("datetime")
                .HasColumnName("periodo");
            entity.Property(e => e.Rect).HasColumnName("rect");
            entity.Property(e => e.Repite).HasColumnName("repite");
            entity.Property(e => e.Titem1).HasColumnName("titem1");
            entity.Property(e => e.Titem2).HasColumnName("titem2");
            entity.Property(e => e.Titem3).HasColumnName("titem3");
            entity.Property(e => e.Titem4).HasColumnName("titem4");
            entity.Property(e => e.Trans1).HasColumnName("trans1");
            entity.Property(e => e.Trans2).HasColumnName("trans2");
            entity.Property(e => e.Trans3).HasColumnName("trans3");
            entity.Property(e => e.Usuario)
                .HasMaxLength(20)
                .HasColumnName("usuario");
        });

        modelBuilder.Entity<Deposito>(entity =>
        {
            entity.Property(e => e.Estado).HasDefaultValue(1);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.Ubicacion).HasMaxLength(100);
        });

        modelBuilder.Entity<DetalleCanje>(entity =>
        {
            entity.ToTable("detalle_canje");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cantidad).HasColumnName("CANTIDAD");
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("DESCRIPCION");
            entity.Property(e => e.IdCanje).HasColumnName("ID_CANJE");
        });

        modelBuilder.Entity<DetalleTipoPago>(entity =>
        {
            entity.ToTable("detalle_tipo_pago");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estado)
                .HasComment("0 - En espera  / 1 - Cobrado / 2 - Rechazado")
                .HasColumnName("estado");
            entity.Property(e => e.FechaVenc)
                .HasColumnType("datetime")
                .HasColumnName("fecha_venc");
            entity.Property(e => e.IdCobroDetalle).HasColumnName("id_cobro_detalle");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.NroCehque)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nro_cehque");
        });

        modelBuilder.Entity<Efectivo>(entity =>
        {
            entity.ToTable("Efectivo");

            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(15, 2)");
        });

        modelBuilder.Entity<EmailsCredenciale>(entity =>
        {
            entity.Property(e => e.BodyText).HasMaxLength(1000);
            entity.Property(e => e.DisplayName).HasMaxLength(100);
            entity.Property(e => e.FromPassword).HasMaxLength(100);
            entity.Property(e => e.MailAdress).HasMaxLength(100);
        });

        modelBuilder.Entity<EntregasMochila>(entity =>
        {
            entity.HasKey(e => e.IdEntrega);

            entity.ToTable("entregas_mochilas");

            entity.Property(e => e.IdEntrega).HasColumnName("id_entrega");
            entity.Property(e => e.CodFliar).HasColumnName("cod_fliar");
            entity.Property(e => e.CodigoUsuarioEntrega).HasColumnName("codigo_usuario_entrega");
            entity.Property(e => e.CodigoUsuarioRecepcion).HasColumnName("codigo_usuario_recepcion");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.EntregaMochila).HasColumnName("entrega_mochila");
            entity.Property(e => e.Exepcion).HasColumnName("exepcion");
            entity.Property(e => e.FechaEntregaMochila)
                .HasColumnType("datetime")
                .HasColumnName("fecha_entrega_mochila");
            entity.Property(e => e.FechaRecepcionDocum)
                .HasColumnType("datetime")
                .HasColumnName("fecha_recepcion_docum");
            entity.Property(e => e.FondoDesempleo).HasColumnName("fondo_desempleo");
            entity.Property(e => e.Legajo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("legajo");
            entity.Property(e => e.NroDocFliar).HasColumnName("nro_doc_fliar");
            entity.Property(e => e.NumeroEntrega).HasColumnName("numero_entrega");
            entity.Property(e => e.RecibeDocum).HasColumnName("recibe_docum");
            entity.Property(e => e.TipoMochila).HasColumnName("tipo_mochila");
        });

        modelBuilder.Entity<Equipo>(entity =>
        {
            entity.ToTable("equipos");

            entity.Property(e => e.Equipoid).HasColumnName("EQUIPOID");
            entity.Property(e => e.EquipoCatid).HasColumnName("EQUIPO_CATID");
            entity.Property(e => e.EquipoGrupoid).HasColumnName("EQUIPO_GRUPOID");
            entity.Property(e => e.Equiponombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("EQUIPONOMBRE");
        });

        modelBuilder.Entity<EquipoEscudo>(entity =>
        {
            entity.ToTable("EquipoEscudo");
        });

        modelBuilder.Entity<EscalaSalarial>(entity =>
        {
            entity.ToTable("EscalaSalarial");

            entity.Property(e => e.Acuerdo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Periodo).HasColumnType("datetime");
        });

        modelBuilder.Entity<EstudioContableEmpresa>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EstudioContableEmpresa");

            entity.Property(e => e.Cuit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUIT");
        });

        modelBuilder.Entity<EstudiosContable>(entity =>
        {
            entity.Property(e => e.Cuit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono2)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.EventosId);

            entity.ToTable("eventos");

            entity.Property(e => e.EventosId).HasColumnName("eventos_id");
            entity.Property(e => e.EventosEstado)
                .HasDefaultValue(1)
                .HasColumnName("eventos_estado");
            entity.Property(e => e.EventosFin)
                .HasColumnType("datetime")
                .HasColumnName("eventos_fin");
            entity.Property(e => e.EventosHorafin).HasColumnName("eventos_horafin");
            entity.Property(e => e.EventosInicio)
                .HasColumnType("datetime")
                .HasColumnName("eventos_inicio");
            entity.Property(e => e.EventosNombre)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("eventos_nombre");
        });

        modelBuilder.Entity<EventosArt>(entity =>
        {
            entity.HasKey(e => e.EventArtId);

            entity.ToTable("eventos_art");

            entity.Property(e => e.EventArtId).HasColumnName("event_art_id");
            entity.Property(e => e.EventArtArtId).HasColumnName("event_art_art_id");
            entity.Property(e => e.EventArtEstado).HasColumnName("event_art_estado");
            entity.Property(e => e.EventArtEventId).HasColumnName("event_art_event_id");
        });

        modelBuilder.Entity<EventosArtAsig>(entity =>
        {
            entity.ToTable("eventos_art_asig");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EventoArticuloId).HasColumnName("EventoArticulo_ID");
            entity.Property(e => e.EventoCuponId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("EventoCupon_ID");
        });

        modelBuilder.Entity<EventosAño>(entity =>
        {
            entity.ToTable("EventosA�o");

            entity.Property(e => e.Comentario)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.CostoDeEntrada).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Liena6).IsUnicode(false);
            entity.Property(e => e.Linea1).IsUnicode(false);
            entity.Property(e => e.Linea10).IsUnicode(false);
            entity.Property(e => e.Linea11).IsUnicode(false);
            entity.Property(e => e.Linea12).IsUnicode(false);
            entity.Property(e => e.Linea13).IsUnicode(false);
            entity.Property(e => e.Linea14).IsUnicode(false);
            entity.Property(e => e.Linea2).IsUnicode(false);
            entity.Property(e => e.Linea3).IsUnicode(false);
            entity.Property(e => e.Linea4).IsUnicode(false);
            entity.Property(e => e.Linea5).IsUnicode(false);
            entity.Property(e => e.Linea7).IsUnicode(false);
            entity.Property(e => e.Linea8).IsUnicode(false);
            entity.Property(e => e.Linea9).IsUnicode(false);
            entity.Property(e => e.LugarFecha)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.NombreEvento)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EventosCupone>(entity =>
        {
            entity.HasKey(e => e.EventcuponId).HasName("PK_eventos_cupones_1");

            entity.ToTable("eventos_cupones");

            entity.Property(e => e.EventcuponId).HasColumnName("eventcupon_id");
            entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");
            entity.Property(e => e.ArticuloIdretira).HasColumnName("ArticuloIDRetira");
            entity.Property(e => e.Costo).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.CuilStr)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EsExepcion).HasDefaultValue(0);
            entity.Property(e => e.EventCuponEventExepId).HasColumnName("event_cupon_event_exep_id");
            entity.Property(e => e.EventCuponFecha)
                .HasColumnType("datetime")
                .HasColumnName("event_cupon_fecha");
            entity.Property(e => e.EventCuponNro).HasColumnName("event_cupon_nro");
            entity.Property(e => e.EventcuponEventoId).HasColumnName("eventcupon_evento_id");
            entity.Property(e => e.EventcuponMaefliaCodfliar).HasColumnName("eventcupon_maeflia_codfliar");
            entity.Property(e => e.EventcuponMaesocCuil).HasColumnName("eventcupon_maesoc_cuil");
            entity.Property(e => e.FechaDeEntregaArticulo).HasColumnType("datetime");
            entity.Property(e => e.FechaDeRetiroAsignado).HasColumnType("datetime");
            entity.Property(e => e.QuienRetiraCupon).HasMaxLength(50);
        });

        modelBuilder.Entity<EventosCupone1>(entity =>
        {
            entity.HasKey(e => e.EventcuponId).HasName("PK_eventos_cupones_11");

            entity.ToTable("eventos_cupones_");

            entity.Property(e => e.EventcuponId).HasColumnName("eventcupon_id");
            entity.Property(e => e.ArticuloId).HasColumnName("ArticuloID");
            entity.Property(e => e.ArticuloIdretira).HasColumnName("ArticuloIDRetira");
            entity.Property(e => e.Costo).HasColumnType("decimal(7, 2)");
            entity.Property(e => e.EventCuponEventExepId).HasColumnName("event_cupon_event_exep_id");
            entity.Property(e => e.EventCuponFecha)
                .HasColumnType("datetime")
                .HasColumnName("event_cupon_fecha");
            entity.Property(e => e.EventCuponNro).HasColumnName("event_cupon_nro");
            entity.Property(e => e.EventcuponEventoId).HasColumnName("eventcupon_evento_id");
            entity.Property(e => e.EventcuponMaefliaCodfliar).HasColumnName("eventcupon_maeflia_codfliar");
            entity.Property(e => e.EventcuponMaesocCuil).HasColumnName("eventcupon_maesoc_cuil");
            entity.Property(e => e.FechaDeEntregaArticulo).HasColumnType("datetime");
            entity.Property(e => e.QuienRetiraCupon).HasMaxLength(50);
        });

        modelBuilder.Entity<EventosCupone2>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EventosCupones__1");

            entity.ToTable("EventosCupones_");

            entity.Property(e => e.CodigoFamiliar).IsUnicode(false);
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CuilTitular).IsUnicode(false);
            entity.Property(e => e.DniFamiliar).IsUnicode(false);
            entity.Property(e => e.FechaGeneracion).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<EventosCupone3>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_EventosCupones_");

            entity.ToTable("EventosCupones__");

            entity.Property(e => e.CodigoFamiliar).IsUnicode(false);
            entity.Property(e => e.CuilTitular).IsUnicode(false);
            entity.Property(e => e.DniFamiliar).IsUnicode(false);
            entity.Property(e => e.FechaGeneracion).HasColumnType("datetime");
        });

        modelBuilder.Entity<EventosExep>(entity =>
        {
            entity.HasKey(e => e.EventExepId);

            entity.ToTable("eventos_exep");

            entity.Property(e => e.EventExepId).HasColumnName("event_exep_id");
            entity.Property(e => e.EventExepApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("event_exep_apellido");
            entity.Property(e => e.EventExepDni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("event_exep_dni");
            entity.Property(e => e.EventExepFechanac)
                .HasColumnType("datetime")
                .HasColumnName("event_exep_fechanac");
            entity.Property(e => e.EventExepNombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("event_exep_nombre");
            entity.Property(e => e.EventExepParent).HasColumnName("event_exep_parent");
            entity.Property(e => e.EventExepSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("event_exep_sexo");
            entity.Property(e => e.EventExepSocioCuil).HasColumnName("event_exep_socio_cuil");
        });

        modelBuilder.Entity<Fase>(entity =>
        {
            entity.ToTable("fases");

            entity.Property(e => e.FaseId).HasColumnName("FASE_ID");
            entity.Property(e => e.Fasedescripcion)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FASEDESCRIPCION");
            entity.Property(e => e.Fasenombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FASENOMBRE");
        });

        modelBuilder.Entity<Filial>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Empresa");

            entity.ToTable("Filial");

            entity.Property(e => e.Aux1).HasMaxLength(500);
            entity.Property(e => e.Aux2).HasMaxLength(500);
            entity.Property(e => e.CarenciaMochilas).HasColumnType("datetime");
            entity.Property(e => e.Domicilio).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.InteresMensualPorMora).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Localidad).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
            entity.Property(e => e.NombreCorto).HasMaxLength(100);
            entity.Property(e => e.PorcentajeDescuentoLey).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.PorcentajeDescuentoSocio).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Provincia).HasMaxLength(50);
            entity.Property(e => e.SecretariaDeLaMujer).HasMaxLength(100);
            entity.Property(e => e.SecretarioGeneral).HasMaxLength(100);
            entity.Property(e => e.SubSecretario).HasMaxLength(100);
            entity.Property(e => e.Telefono).HasMaxLength(50);
        });

        modelBuilder.Entity<FormaDePago>(entity =>
        {
            entity.ToTable("FormaDePago");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Foto>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("fotos", "fotos_");

            entity.Property(e => e.CuilStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIL_STR");
            entity.Property(e => e.FotosCodfliar).HasColumnName("FOTOS_CODFLIAR");
            entity.Property(e => e.FotosCuil).HasColumnName("FOTOS_CUIL");
            entity.Property(e => e.FotosFecha).HasColumnName("FOTOS_FECHA");
            entity.Property(e => e.FotosFoto).HasColumnName("FOTOS_FOTO");
        });

        modelBuilder.Entity<Grupo>(entity =>
        {
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Grupo1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Grupo");
        });

        modelBuilder.Entity<ImpresionActa>(entity =>
        {
            entity.HasKey(e => e.IdImpresionActas).HasName("PK_imprecion_actas");

            entity.ToTable("impresion_actas");

            entity.Property(e => e.IdImpresionActas).HasColumnName("id_impresion_actas");
            entity.Property(e => e.Acta)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("acta");
            entity.Property(e => e.Cobrado)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("cobrado");
            entity.Property(e => e.Desde)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("desde");
            entity.Property(e => e.Fecha1)
                .HasDefaultValueSql("(((1900)-(1))-(1))")
                .HasColumnType("datetime")
                .HasColumnName("fecha1");
            entity.Property(e => e.Fecha2)
                .HasDefaultValueSql("(((1900)-(1))-(1))")
                .HasColumnType("datetime")
                .HasColumnName("fecha2");
            entity.Property(e => e.Fecha3)
                .HasDefaultValueSql("(((1900)-(1))-(1))")
                .HasColumnType("datetime")
                .HasColumnName("fecha3");
            entity.Property(e => e.Hasta)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("hasta");
            entity.Property(e => e.Importe)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe");
            entity.Property(e => e.Inspector)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("inspector");
            entity.Property(e => e.Num1)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("num1");
            entity.Property(e => e.Num2)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("num2");
            entity.Property(e => e.Num3)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("num3");
        });

        modelBuilder.Entity<ImpresionComprobante>(entity =>
        {
            entity.HasKey(e => e.IdEntrega).HasName("PK_impresion_comprobante_1");

            entity.ToTable("impresion_comprobante");

            entity.Property(e => e.IdEntrega).HasColumnName("id_entrega");
            entity.Property(e => e.AporteLey)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("aporte_ley");
            entity.Property(e => e.AporteSocio)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("aporte_socio");
            entity.Property(e => e.BenefApenom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("benef_apenom");
            entity.Property(e => e.BenefDni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("benef_dni");
            entity.Property(e => e.BenefEdad).HasColumnName("benef_edad");
            entity.Property(e => e.BenefFdoDesempleo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("benef_fdo_desempleo");
            entity.Property(e => e.BenefLegajo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("benef_legajo");
            entity.Property(e => e.BenefSexo)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("benef_sexo");
            entity.Property(e => e.BenefTipoMochila)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("benef_tipo_mochila");
            entity.Property(e => e.Campeonato)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("CAMPEONATO");
            entity.Property(e => e.Cancha)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CANCHA");
            entity.Property(e => e.CantidadEmpleados).HasColumnName("cantidad_empleados");
            entity.Property(e => e.CantidadSocios).HasColumnName("cantidad_socios");
            entity.Property(e => e.Capital)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("capital");
            entity.Property(e => e.Categoria)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CATEGORIA");
            entity.Property(e => e.Col1dni)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("COL1DNI");
            entity.Property(e => e.Col1empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COL1EMPRESA");
            entity.Property(e => e.Col1foto).HasColumnName("COL1FOTO");
            entity.Property(e => e.Col1nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COL1NOMBRE");
            entity.Property(e => e.Col1nrosocio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COL1NROSOCIO");
            entity.Property(e => e.Col2dni)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("COL2DNI");
            entity.Property(e => e.Col2empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COL2EMPRESA");
            entity.Property(e => e.Col2foto).HasColumnName("COL2FOTO");
            entity.Property(e => e.Col2nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("COL2NOMBRE");
            entity.Property(e => e.Col2nrosocio)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("COL2NROSOCIO");
            entity.Property(e => e.Comentario)
                .IsUnicode(false)
                .HasColumnName("comentario");
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("cuit");
            entity.Property(e => e.Desde)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("desde");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("domicilio");
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("empresa");
            entity.Property(e => e.Equipo)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EQUIPO");
            entity.Property(e => e.Estudio)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estudio");
            entity.Property(e => e.Fase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("FASE");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
            entity.Property(e => e.Fecha1)
                .HasColumnType("datetime")
                .HasColumnName("fecha1");
            entity.Property(e => e.Fecha2)
                .HasColumnType("datetime")
                .HasColumnName("fecha2");
            entity.Property(e => e.Fecha3)
                .HasColumnType("datetime")
                .HasColumnName("fecha3");
            entity.Property(e => e.Fecha4)
                .HasColumnType("datetime")
                .HasColumnName("fecha4");
            entity.Property(e => e.Fecha5)
                .HasColumnType("datetime")
                .HasColumnName("fecha5");
            entity.Property(e => e.Fechapago)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("fechapago");
            entity.Property(e => e.Hasta)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("hasta");
            entity.Property(e => e.Hora)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HORA");
            entity.Property(e => e.ImporteDepositado)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("importe_depositado");
            entity.Property(e => e.Interes)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("interes");
            entity.Property(e => e.Localidad)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("localidad");
            entity.Property(e => e.NroEntrega).HasColumnName("nro_entrega");
            entity.Property(e => e.NroSocio).HasColumnName("nro_socio");
            entity.Property(e => e.Nrofecha)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NROFECHA");
            entity.Property(e => e.Partidoid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PARTIDOID");
            entity.Property(e => e.Periodo)
                .HasColumnType("datetime")
                .HasColumnName("periodo");
            entity.Property(e => e.Rectificacion).HasColumnName("rectificacion");
            entity.Property(e => e.SancionCantidad)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sancion_cantidad");
            entity.Property(e => e.SancionXDe)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("sancion_x_de");
            entity.Property(e => e.SocioApenom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("socio_apenom");
            entity.Property(e => e.SocioDni)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("socio_dni");
            entity.Property(e => e.SocioEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("socio_empresa");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.Total)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("total");
        });

        modelBuilder.Entity<Inspectore>(entity =>
        {
            entity.HasKey(e => e.IdInspector);

            entity.ToTable("inspectores");

            entity.Property(e => e.IdInspector).HasColumnName("ID_INSPECTOR");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APELLIDO");
            entity.Property(e => e.Estudio)
                .HasDefaultValue(0)
                .HasColumnName("ESTUDIO");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NOMBRE");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("TELEFONO");
        });

        modelBuilder.Entity<InspectoresAsignacionEmpresa>(entity =>
        {
            entity.HasKey(e => e.IdAsignacion);

            entity.ToTable("inspectores_asignacion_empresa");

            entity.Property(e => e.IdAsignacion).HasColumnName("ID_ASIGNACION");
            entity.Property(e => e.ActaGenerada).HasColumnName("ACTA_GENERADA");
            entity.Property(e => e.Anticipo)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ANTICIPO");
            entity.Property(e => e.Capital)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("CAPITAL");
            entity.Property(e => e.Coeficiente)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("COEFICIENTE");
            entity.Property(e => e.CuitEmpresa).HasColumnName("CUIT_EMPRESA");
            entity.Property(e => e.Cuotas).HasColumnName("CUOTAS");
            entity.Property(e => e.Desde)
                .HasColumnType("datetime")
                .HasColumnName("DESDE");
            entity.Property(e => e.DeudaAproximada)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DEUDA_APROXIMADA");
            entity.Property(e => e.DeudaDeterminada)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DEUDA_DETERMINADA");
            entity.Property(e => e.Dias).HasColumnName("DIAS");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.FechaAsignacion)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ASIGNACION");
            entity.Property(e => e.FechaEntregaAviso)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_ENTREGA_AVISO");
            entity.Property(e => e.FechaGeneracionActa)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_GENERACION_ACTA");
            entity.Property(e => e.Financiacion).HasColumnName("FINANCIACION");
            entity.Property(e => e.Hasta)
                .HasColumnType("datetime")
                .HasColumnName("HASTA");
            entity.Property(e => e.IdInspector).HasColumnName("ID_INSPECTOR");
            entity.Property(e => e.ImporteCuota)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("IMPORTE_CUOTA");
            entity.Property(e => e.IntResarc)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INT_RESARC");
            entity.Property(e => e.InteresFinanciacion)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("INTERES_FINANCIACION");
            entity.Property(e => e.NroAviso).HasColumnName("NRO_AVISO");
            entity.Property(e => e.PeriodoDesde).HasColumnName("PERIODO_DESDE");
            entity.Property(e => e.PeriodoHasta).HasColumnName("PERIODO_HASTA");
            entity.Property(e => e.Tasa)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("TASA");
        });

        modelBuilder.Entity<Interese>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Intereses_1");

            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Diario).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Mensual).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.Norma).HasMaxLength(60);
        });

        modelBuilder.Entity<Interese1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Intereses");

            entity.ToTable("Intereses_");

            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Diario).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Mensual).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.Norma).HasMaxLength(60);
        });

        modelBuilder.Entity<Juece>(entity =>
        {
            entity.HasKey(e => e.Juezid);

            entity.ToTable("jueces");

            entity.Property(e => e.Juezid).HasColumnName("JUEZID");
            entity.Property(e => e.Juezapellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUEZAPELLIDO");
            entity.Property(e => e.Juezdni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("JUEZDNI");
            entity.Property(e => e.Jueznombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUEZNOMBRE");
            entity.Property(e => e.Jueztelefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUEZTELEFONO");
        });

        modelBuilder.Entity<JugadorGol>(entity =>
        {
            entity.ToTable("JugadorGol");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApeNom)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CreateDatetime).HasColumnType("datetime");
            entity.Property(e => e.Equipo)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<JugadorTarjetum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FechaCreacion).HasColumnType("datetime");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<Jugadore>(entity =>
        {
            entity.HasKey(e => e.Jugid);

            entity.ToTable("jugadores");

            entity.Property(e => e.Jugid).HasColumnName("JUGID");
            entity.Property(e => e.JugApellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("JUG_APELLIDO");
            entity.Property(e => e.JugEmpresa)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("JUG_EMPRESA");
            entity.Property(e => e.JugEquipoid).HasColumnName("JUG_EQUIPOID");
            entity.Property(e => e.JugEstado).HasColumnName("JUG_ESTADO");
            entity.Property(e => e.JugFoto)
                .HasColumnType("image")
                .HasColumnName("JUG_FOTO");
            entity.Property(e => e.JugMaesocNroafil)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("JUG_MAESOC_NROAFIL");
            entity.Property(e => e.JugNombre)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("JUG_NOMBRE");
            entity.Property(e => e.JugSoccencuil).HasColumnName("JUG_SOCCENCUIL");
            entity.Property(e => e.JugTipo).HasColumnName("JUG_TIPO");
        });

        modelBuilder.Entity<JugadoresExepcione>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("jugadores_exepciones");

            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.CategoriaId).HasColumnName("categoria_ID");
            entity.Property(e => e.Cuil).HasColumnName("cuil");
            entity.Property(e => e.Dni).HasColumnName("dni");
            entity.Property(e => e.EquipoId).HasColumnName("equipo_ID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.Tipo).HasColumnName("tipo");
        });

        modelBuilder.Entity<Liga>(entity =>
        {
            entity.ToTable("ligas");

            entity.Property(e => e.Ligaid).HasColumnName("LIGAID");
            entity.Property(e => e.Ligaestado).HasColumnName("LIGAESTADO");
            entity.Property(e => e.Liganombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("LIGANOMBRE");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("localidad");

            entity.Property(e => e.MaelocCodloc).HasColumnName("MAELOC_CODLOC");
            entity.Property(e => e.MaelocCodprov)
                .HasMaxLength(255)
                .HasColumnName("MAELOC_CODPROV");
            entity.Property(e => e.MaelocNombre)
                .HasMaxLength(255)
                .HasColumnName("MAELOC_NOMBRE");
        });

        modelBuilder.Entity<Localidade>(entity =>
        {
            entity.ToTable("localidades");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Codigopostal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("codigopostal");
            entity.Property(e => e.Idlocalidades).HasColumnName("idlocalidades");
            entity.Property(e => e.Idprovincias).HasColumnName("idprovincias");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Maeemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maeemp", "fotos_");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.MaeempActualiza).HasColumnName("MAEEMP_ACTUALIZA");
            entity.Property(e => e.MaeempCalle)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_CALLE");
            entity.Property(e => e.MaeempCodloc).HasColumnName("MAEEMP_CODLOC");
            entity.Property(e => e.MaeempCodpos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_CODPOS");
            entity.Property(e => e.MaeempCodprov)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_CODPROV");
            entity.Property(e => e.MaeempCondcred)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_CONDCRED");
            entity.Property(e => e.MaeempCondiva).HasColumnName("MAEEMP_CONDIVA");
            entity.Property(e => e.MaeempCredmax).HasColumnName("MAEEMP_CREDMAX");
            entity.Property(e => e.MaeempCuit).HasColumnName("MAEEMP_CUIT");
            entity.Property(e => e.MaeempEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_EMAIL");
            entity.Property(e => e.MaeempEstudioContacto)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_ESTUDIO_CONTACTO");
            entity.Property(e => e.MaeempEstudioEmail)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_ESTUDIO_EMAIL");
            entity.Property(e => e.MaeempEstudioTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_ESTUDIO_TEL");
            entity.Property(e => e.MaeempNomfan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_NOMFAN");
            entity.Property(e => e.MaeempNro)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_NRO");
            entity.Property(e => e.MaeempRazsoc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_RAZSOC");
            entity.Property(e => e.MaeempTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEEMP_TEL");
            entity.Property(e => e.MeempCuitStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MEEMP_CUIT_STR");
        });

        modelBuilder.Entity<Maeflium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maeflia", "fotos_");

            entity.Property(e => e.MaefliaApellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_APELLIDO");
            entity.Property(e => e.MaefliaAñoestablec)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_A�OESTABLEC");
            entity.Property(e => e.MaefliaCodfliar).HasColumnName("MAEFLIA_CODFLIAR");
            entity.Property(e => e.MaefliaDiscapac).HasColumnName("MAEFLIA_DISCAPAC");
            entity.Property(e => e.MaefliaEstablec)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_ESTABLEC");
            entity.Property(e => e.MaefliaEstcivil)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_ESTCIVIL");
            entity.Property(e => e.MaefliaEstudia).HasColumnName("MAEFLIA_ESTUDIA");
            entity.Property(e => e.MaefliaFecing).HasColumnName("MAEFLIA_FECING");
            entity.Property(e => e.MaefliaFecnac).HasColumnName("MAEFLIA_FECNAC");
            entity.Property(e => e.MaefliaGrusan).HasColumnName("MAEFLIA_GRUSAN");
            entity.Property(e => e.MaefliaNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_NOMBRE");
            entity.Property(e => e.MaefliaNrocarnet)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_NROCARNET");
            entity.Property(e => e.MaefliaNrodoc).HasColumnName("MAEFLIA_NRODOC");
            entity.Property(e => e.MaefliaRecbib).HasColumnName("MAEFLIA_RECBIB");
            entity.Property(e => e.MaefliaReccen).HasColumnName("MAEFLIA_RECCEN");
            entity.Property(e => e.MaefliaRecfam).HasColumnName("MAEFLIA_RECFAM");
            entity.Property(e => e.MaefliaRecfar).HasColumnName("MAEFLIA_RECFAR");
            entity.Property(e => e.MaefliaRecfoc).HasColumnName("MAEFLIA_RECFOC");
            entity.Property(e => e.MaefliaSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_SEXO");
            entity.Property(e => e.MaefliaTalle)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAEFLIA_TALLE");
            entity.Property(e => e.MaefliaTipodoc).HasColumnName("MAEFLIA_TIPODOC");
        });

        modelBuilder.Entity<Maesoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("maesoc", "fotos_");

            entity.Property(e => e.Apenom)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("APENOM");
            entity.Property(e => e.MaesocActualiza).HasColumnName("MAESOC_ACTUALIZA");
            entity.Property(e => e.MaesocApellido)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_APELLIDO");
            entity.Property(e => e.MaesocBarrio)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_BARRIO");
            entity.Property(e => e.MaesocCalle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_CALLE");
            entity.Property(e => e.MaesocCargaflia).HasColumnName("MAESOC_CARGAFLIA");
            entity.Property(e => e.MaesocCodact).HasColumnName("MAESOC_CODACT");
            entity.Property(e => e.MaesocCodcat).HasColumnName("MAESOC_CODCAT");
            entity.Property(e => e.MaesocCodcon).HasColumnName("MAESOC_CODCON");
            entity.Property(e => e.MaesocCodloc).HasColumnName("MAESOC_CODLOC");
            entity.Property(e => e.MaesocCodosm).HasColumnName("MAESOC_CODOSM");
            entity.Property(e => e.MaesocCodpos)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_CODPOS");
            entity.Property(e => e.MaesocCodprov)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_CODPROV");
            entity.Property(e => e.MaesocCuil).HasColumnName("MAESOC_CUIL");
            entity.Property(e => e.MaesocCuilStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MAESOC_CUIL_STR");
            entity.Property(e => e.MaesocDebautCbu)
                .HasMaxLength(22)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_DEBAUT_CBU");
            entity.Property(e => e.MaesocDebautMonto).HasColumnName("MAESOC_DEBAUT_MONTO");
            entity.Property(e => e.MaesocDto)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_DTO");
            entity.Property(e => e.MaesocDtofarmacia).HasColumnName("MAESOC_DTOFARMACIA");
            entity.Property(e => e.MaesocEmail)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_EMAIL");
            entity.Property(e => e.MaesocEmaillab)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_EMAILLAB");
            entity.Property(e => e.MaesocEstciv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_ESTCIV");
            entity.Property(e => e.MaesocFechaalta).HasColumnName("MAESOC_FECHAALTA");
            entity.Property(e => e.MaesocFechadesempleo).HasColumnName("MAESOC_FECHADESEMPLEO");
            entity.Property(e => e.MaesocFechadoc).HasColumnName("MAESOC_FECHADOC");
            entity.Property(e => e.MaesocFechamod).HasColumnName("MAESOC_FECHAMOD");
            entity.Property(e => e.MaesocFechanac).HasColumnName("MAESOC_FECHANAC");
            entity.Property(e => e.MaesocGruposang).HasColumnName("MAESOC_GRUPOSANG");
            entity.Property(e => e.MaesocImpest1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_IMPEST1");
            entity.Property(e => e.MaesocImpest2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_IMPEST2");
            entity.Property(e => e.MaesocImpest3)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_IMPEST3");
            entity.Property(e => e.MaesocImpest4)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_IMPEST4");
            entity.Property(e => e.MaesocImpest5)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_IMPEST5");
            entity.Property(e => e.MaesocImpest6)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_IMPEST6");
            entity.Property(e => e.MaesocJubil).HasColumnName("MAESOC_JUBIL");
            entity.Property(e => e.MaesocNacionalidad)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_NACIONALIDAD");
            entity.Property(e => e.MaesocNombre)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_NOMBRE");
            entity.Property(e => e.MaesocNroafil)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_NROAFIL");
            entity.Property(e => e.MaesocNrocalle)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_NROCALLE");
            entity.Property(e => e.MaesocNrocarnet)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_NROCARNET");
            entity.Property(e => e.MaesocNrodoc)
                .HasMaxLength(11)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_NRODOC");
            entity.Property(e => e.MaesocPiso)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_PISO");
            entity.Property(e => e.MaesocPredoc).HasColumnName("MAESOC_PREDOC");
            entity.Property(e => e.MaesocSexo)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_SEXO");
            entity.Property(e => e.MaesocTel)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_TEL");
            entity.Property(e => e.MaesocTelcel)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_TELCEL");
            entity.Property(e => e.MaesocTipodoc).HasColumnName("MAESOC_TIPODOC");
            entity.Property(e => e.MaesocUsumod)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("MAESOC_USUMOD");
        });

        modelBuilder.Entity<Marca>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Marcas_1");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Marca1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Marcas");

            entity.ToTable("Marcas_");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Novedade>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cuit)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.EstadoMensajeAlCobrador).HasComment("1= Leido, 0 = Pendiente de Lectura");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaCompromiso).HasColumnType("datetime");
            entity.Property(e => e.IdActa).HasColumnName("Id_Acta");
            entity.Property(e => e.MensajeAlCobrador).HasComment("1= tiene Mensaje - 0 = No tiene Mensaje");
            entity.Property(e => e.Novedad)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Vd).HasColumnName("VD");
        });

        modelBuilder.Entity<Objeto>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Estado).HasDefaultValue(0);
            entity.Property(e => e.ModuloId).HasDefaultValue(0);
            entity.Property(e => e.Nombre).HasMaxLength(40);
            entity.Property(e => e.RolId).HasDefaultValue(0);
        });

        modelBuilder.Entity<Obrasocial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("obrasocial");

            entity.Property(e => e.MaeosmCodosm).HasColumnName("MAEOSM_CODOSM");
            entity.Property(e => e.MaeosmDescri)
                .HasMaxLength(255)
                .HasColumnName("MAEOSM_DESCRI");
            entity.Property(e => e.MaeosmSigla)
                .HasMaxLength(255)
                .HasColumnName("MAEOSM_SIGLA");
        });

        modelBuilder.Entity<ParaInspeccion>(entity =>
        {
            entity.ToTable("ParaInspeccion");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cuil)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUIL");
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.Estado).HasColumnName("ESTADO");
            entity.Property(e => e.Fecha)
                .HasColumnType("datetime")
                .HasColumnName("FECHA");
        });

        modelBuilder.Entity<Parentesco>(entity =>
        {
            entity.HasKey(e => e.ParentId);

            entity.ToTable("parentesco");

            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.ParentCodigo).HasColumnName("parent_codigo");
            entity.Property(e => e.ParentDescrip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("parent_descrip");
            entity.Property(e => e.ParentEstado)
                .HasDefaultValue(1)
                .HasColumnName("parent_estado");
        });

        modelBuilder.Entity<Parjugcamisetum>(entity =>
        {
            entity.HasKey(e => e.Parjugcamiid);

            entity.ToTable("parjugcamiseta");

            entity.Property(e => e.Parjugcamiid).HasColumnName("PARJUGCAMIID");
            entity.Property(e => e.ParjugcamiJugid).HasColumnName("PARJUGCAMI_JUGID");
            entity.Property(e => e.ParjugcamiPartidoid).HasColumnName("PARJUGCAMI_PARTIDOID");
            entity.Property(e => e.Parjugcaminro).HasColumnName("PARJUGCAMINRO");
        });

        modelBuilder.Entity<Partido>(entity =>
        {
            entity.HasKey(e => e.Partidoid).HasName("PK_partidos_2024");

            entity.ToTable("partidos");

            entity.Property(e => e.Partidoid).HasColumnName("PARTIDOID");
            entity.Property(e => e.PartidoCampid).HasColumnName("PARTIDO_CAMPID");
            entity.Property(e => e.PartidoCanchaid).HasColumnName("PARTIDO_CANCHAID");
            entity.Property(e => e.PartidoCatid).HasColumnName("PARTIDO_CATID");
            entity.Property(e => e.PartidoFaseid).HasColumnName("PARTIDO_FASEID");
            entity.Property(e => e.PartidoGrupoid).HasColumnName("PARTIDO_GRUPOID");
            entity.Property(e => e.PartidoLigaid).HasColumnName("PARTIDO_LIGAID");
            entity.Property(e => e.Partidoequipo1).HasColumnName("PARTIDOEQUIPO1");
            entity.Property(e => e.Partidoequipo1goles).HasColumnName("PARTIDOEQUIPO1GOLES");
            entity.Property(e => e.Partidoequipo2).HasColumnName("PARTIDOEQUIPO2");
            entity.Property(e => e.Partidoequipo2goles).HasColumnName("PARTIDOEQUIPO2GOLES");
            entity.Property(e => e.Partidofecha).HasColumnName("PARTIDOFECHA");
            entity.Property(e => e.Partidohora).HasColumnName("PARTIDOHORA");
            entity.Property(e => e.Partidonrofecha).HasColumnName("PARTIDONROFECHA");
        });

        modelBuilder.Entity<Partidos2023>(entity =>
        {
            entity.HasKey(e => e.Partidoid).HasName("PK_partidos");

            entity.ToTable("partidos_2023");

            entity.Property(e => e.Partidoid).HasColumnName("PARTIDOID");
            entity.Property(e => e.PartidoCampid).HasColumnName("PARTIDO_CAMPID");
            entity.Property(e => e.PartidoCanchaid).HasColumnName("PARTIDO_CANCHAID");
            entity.Property(e => e.PartidoCatid).HasColumnName("PARTIDO_CATID");
            entity.Property(e => e.PartidoFaseid).HasColumnName("PARTIDO_FASEID");
            entity.Property(e => e.PartidoGrupoid).HasColumnName("PARTIDO_GRUPOID");
            entity.Property(e => e.PartidoLigaid).HasColumnName("PARTIDO_LIGAID");
            entity.Property(e => e.Partidoequipo1).HasColumnName("PARTIDOEQUIPO1");
            entity.Property(e => e.Partidoequipo1goles).HasColumnName("PARTIDOEQUIPO1GOLES");
            entity.Property(e => e.Partidoequipo2).HasColumnName("PARTIDOEQUIPO2");
            entity.Property(e => e.Partidoequipo2goles).HasColumnName("PARTIDOEQUIPO2GOLES");
            entity.Property(e => e.Partidofecha).HasColumnName("PARTIDOFECHA");
            entity.Property(e => e.Partidohora).HasColumnName("PARTIDOHORA");
            entity.Property(e => e.Partidonrofecha).HasColumnName("PARTIDONROFECHA");
        });

        modelBuilder.Entity<PartidosCambio>(entity =>
        {
            entity.HasKey(e => e.Particambioid);

            entity.ToTable("partidos_cambios");

            entity.Property(e => e.Particambioid).HasColumnName("PARTICAMBIOID");
            entity.Property(e => e.ParticambioMinuto).HasColumnName("PARTICAMBIO_MINUTO");
            entity.Property(e => e.ParticambioPartidoid).HasColumnName("PARTICAMBIO_PARTIDOID");
            entity.Property(e => e.ParticambioTiempo).HasColumnName("PARTICAMBIO_TIEMPO");
            entity.Property(e => e.ParticambioentraParjugcamiid).HasColumnName("PARTICAMBIOENTRA_PARJUGCAMIID");
            entity.Property(e => e.ParticambiosaleParjugcamiid).HasColumnName("PARTICAMBIOSALE_PARJUGCAMIID");
        });

        modelBuilder.Entity<PartidosJuece>(entity =>
        {
            entity.HasKey(e => e.Partijuezid);

            entity.ToTable("partidos_jueces");

            entity.Property(e => e.Partijuezid).HasColumnName("PARTIJUEZID");
            entity.Property(e => e.PartijuezJuezid).HasColumnName("PARTIJUEZ_JUEZID");
            entity.Property(e => e.PartijuezPartidoid).HasColumnName("PARTIJUEZ_PARTIDOID");
        });

        modelBuilder.Entity<PartidosTarjeta>(entity =>
        {
            entity.HasKey(e => e.Partitarjid);

            entity.ToTable("partidos_tarjetas");

            entity.Property(e => e.Partitarjid).HasColumnName("PARTITARJID");
            entity.Property(e => e.PartitarjJugid).HasColumnName("PARTITARJ_JUGID");
            entity.Property(e => e.PartitarjPartidoid).HasColumnName("PARTITARJ_PARTIDOID");
            entity.Property(e => e.PartitarjTarjetaid).HasColumnName("PARTITARJ_TARJETAID");
            entity.Property(e => e.Partitarjminuto)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PARTITARJMINUTO");
            entity.Property(e => e.Partitarjmotivo)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("PARTITARJMOTIVO");
            entity.Property(e => e.Partitarjtiempo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("PARTITARJTIEMPO");
        });

        modelBuilder.Entity<Permiso>(entity =>
        {
            entity.HasKey(e => e.IdPermiso);
        });

        modelBuilder.Entity<PlanDetalle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlanDetalle");

            entity.Property(e => e.Aamortizar)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("AAmortizar");
            entity.Property(e => e.Amortizado).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCancela).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.ImporteCobrado).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ImporteCuotaCapital).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Interes).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.InteresResarcitorio).HasColumnType("decimal(15, 2)");
        });

        modelBuilder.Entity<PlanesDePago>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PlanesDePago");

            entity.Property(e => e.ActaId).HasColumnName("ActaID");
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .HasColumnName("CUIT");
            entity.Property(e => e.DeudaInicial).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Premio>(entity =>
        {
            entity.Property(e => e.Codigo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PremiosSorteo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PremioSorteo");

            entity.ToTable("PremiosSorteo");

            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.PremioCodigo)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.Property(e => e.Alias).HasMaxLength(50);
            entity.Property(e => e.Cbu)
                .HasMaxLength(50)
                .HasColumnName("CBU");
            entity.Property(e => e.Cuenta)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CuentaBancaria).HasMaxLength(50);
            entity.Property(e => e.Cuit)
                .HasMaxLength(15)
                .HasColumnName("CUIT");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.RazonSocial)
                .HasMaxLength(70)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Provincia>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("provincias");

            entity.Property(e => e.MaeprovCodpro)
                .HasMaxLength(255)
                .HasColumnName("MAEPROV_CODPRO");
            entity.Property(e => e.MaeprovNombre)
                .HasMaxLength(255)
                .HasColumnName("MAEPROV_NOMBRE");
        });

        modelBuilder.Entity<Quincho>(entity =>
        {
            entity.ToTable("quinchos");

            entity.Property(e => e.Costo)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Limpieza)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SeguroVajilla)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(8, 2)");
            entity.Property(e => e.Turno)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Ranking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ranking");

            entity.Property(e => e.Cuit).HasColumnName("cuit");
            entity.Property(e => e.Deuda)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("deuda");
            entity.Property(e => e.Razons)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("razons");
        });

        modelBuilder.Entity<Recibo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_RecibosDet");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AprobadoFecha).HasColumnType("datetime");
            entity.Property(e => e.FechaAutomatica).HasColumnType("datetime");
            entity.Property(e => e.FechaManual)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NroManual)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RecibosDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Tabla1");

            entity.ToTable("RecibosDetalle");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FechaAut).HasColumnType("datetime");
            entity.Property(e => e.FechaManual).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.NroCuota).HasDefaultValue(1);
        });

        modelBuilder.Entity<ReservasQuincho>(entity =>
        {
            entity.ToTable("reservas_quinchos");

            entity.Property(e => e.Comentario)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.FechaDeCancelacion).HasColumnType("datetime");
            entity.Property(e => e.FechaDeConfirmacion).HasColumnType("datetime");
            entity.Property(e => e.FechaEvento).HasColumnType("datetime");
            entity.Property(e => e.FechaVencReserva).HasColumnType("datetime");
            entity.Property(e => e.FiestaDesde)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.FiestaHasta)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.LlavesDesde)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.LlavesHasta)
                .HasMaxLength(5)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.IdRol).HasName("PK_TipoUsuario");

            entity.Property(e => e.NombreRol).HasMaxLength(50);
        });

        modelBuilder.Entity<RolesControl>(entity =>
        {
            entity.HasKey(e => e.IdRolControl).HasName("PK_RolesObjetos");

            entity.Property(e => e.Estado).HasDefaultValue(1);
        });

        modelBuilder.Entity<Rubro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rubros_1");

            entity.ToTable("rubros");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Rubro1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_rubros");

            entity.ToTable("rubros_");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<SancionFecha>(entity =>
        {
            entity.ToTable("SancionFecha");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.De)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FechaAcumplir).HasColumnName("FechaACumplir");
        });

        modelBuilder.Entity<Sancione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_sanciones_1");

            entity.ToTable("sanciones");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ApeNom)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Equipo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FechaDesde)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DESDE");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HASTA");
            entity.Property(e => e.FechaPartido)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_PARTIDO");
            entity.Property(e => e.TarjetaNombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SancionesAnt>(entity =>
        {
            entity.HasKey(e => e.IdSancion).HasName("PK_sanciones");

            entity.ToTable("sanciones_Ant");

            entity.Property(e => e.IdSancion).HasColumnName("ID_SANCION");
            entity.Property(e => e.CantidadFechas).HasColumnName("CANTIDAD_FECHAS");
            entity.Property(e => e.FechaDesde)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_DESDE");
            entity.Property(e => e.FechaHasta)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_HASTA");
            entity.Property(e => e.FechaPartido)
                .HasColumnType("datetime")
                .HasColumnName("FECHA_PARTIDO");
            entity.Property(e => e.IdJug).HasColumnName("ID_JUG");
            entity.Property(e => e.IdPartido).HasColumnName("ID_PARTIDO");
            entity.Property(e => e.NroFecha).HasColumnName("NRO_FECHA");
        });

        modelBuilder.Entity<SecuenciaPeriodo>(entity =>
        {
            entity.HasKey(e => e.IdSecuenciaPeriodo);

            entity.ToTable("secuencia_periodos");

            entity.Property(e => e.IdSecuenciaPeriodo).HasColumnName("id_secuencia_periodo");
            entity.Property(e => e.Periodo).HasColumnName("periodo");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio);

            entity.ToTable("servicios");

            entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
            entity.Property(e => e.FechaCarga)
                .HasColumnType("datetime")
                .HasColumnName("fecha_carga");
            entity.Property(e => e.NombreServicio)
                .HasMaxLength(100)
                .HasColumnName("nombre_servicio");
            entity.Property(e => e.PrecioServicio)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("precio_servicio");
        });

        modelBuilder.Entity<Sexo>(entity =>
        {
            entity.ToTable("Sexo");

            entity.Property(e => e.Nombre).HasMaxLength(50);
        });

        modelBuilder.Entity<Soccen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("soccen", "fotos_");

            entity.Property(e => e.SoccenActualiza).HasColumnName("SOCCEN_ACTUALIZA");
            entity.Property(e => e.SoccenCodiva).HasColumnName("SOCCEN_CODIVA");
            entity.Property(e => e.SoccenCondcred)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCCEN_CONDCRED");
            entity.Property(e => e.SoccenCredmax).HasColumnName("SOCCEN_CREDMAX");
            entity.Property(e => e.SoccenCuil).HasColumnName("SOCCEN_CUIL");
            entity.Property(e => e.SoccenDespedido).HasColumnName("SOCCEN_DESPEDIDO");
            entity.Property(e => e.SoccenEstado).HasColumnName("SOCCEN_ESTADO");
            entity.Property(e => e.SoccenFebaja).HasColumnName("SOCCEN_FEBAJA");
            entity.Property(e => e.SoccenFeing).HasColumnName("SOCCEN_FEING");
            entity.Property(e => e.SoccenNrorescomdir).HasColumnName("SOCCEN_NRORESCOMDIR");
            entity.Property(e => e.SoccenSocdir).HasColumnName("SOCCEN_SOCDIR");
        });

        modelBuilder.Entity<Socemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socemp", "fotos_");

            entity.Property(e => e.SocempCausabaja)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCEMP_CAUSABAJA");
            entity.Property(e => e.SocempCuil).HasColumnName("SOCEMP_CUIL");
            entity.Property(e => e.SocempCuilStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOCEMP_CUIL_STR");
            entity.Property(e => e.SocempCuite).HasColumnName("SOCEMP_CUITE");
            entity.Property(e => e.SocempCuiteStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SOCEMP_CUITE_STR");
            entity.Property(e => e.SocempEstado).HasColumnName("SOCEMP_ESTADO");
            entity.Property(e => e.SocempFechabaja).HasColumnName("SOCEMP_FECHABAJA");
            entity.Property(e => e.SocempFechaing).HasColumnName("SOCEMP_FECHAING");
            entity.Property(e => e.SocempNroleg)
                .HasMaxLength(6)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCEMP_NROLEG");
            entity.Property(e => e.SocempSociocentro).HasColumnName("SOCEMP_SOCIOCENTRO");
            entity.Property(e => e.SocempUltEmpresa)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SOCEMP_ULT_EMPRESA");
        });

        modelBuilder.Entity<Socflium>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("socflia", "fotos_");

            entity.Property(e => e.CuilStr)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("CUIL_STR");
            entity.Property(e => e.SocfliaCodfliar).HasColumnName("SOCFLIA_CODFLIAR");
            entity.Property(e => e.SocfliaCuil).HasColumnName("SOCFLIA_CUIL");
            entity.Property(e => e.SocfliaEstado).HasColumnName("SOCFLIA_ESTADO");
            entity.Property(e => e.SocfliaParent).HasColumnName("SOCFLIA_PARENT");
        });

        modelBuilder.Entity<Sorteo>(entity =>
        {
            entity.Property(e => e.Descripcion)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SorteosGanadore>(entity =>
        {
            entity.Property(e => e.ApeNomSocio)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Dni)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("DNI");
            entity.Property(e => e.Dnisocio)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("DNISocio");
            entity.Property(e => e.Empresa)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Premio)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoEmpresa)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TelefonoSocio)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SubRubro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SubRubros_1");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<SubRubro1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_SubRubros");

            entity.ToTable("SubRubros_");

            entity.Property(e => e.FechaBaja).HasColumnType("datetime");
            entity.Property(e => e.FechaCarga).HasColumnType("datetime");
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Tarjeta>(entity =>
        {
            entity.ToTable("tarjetas");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NombreReducido)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoComprobante>(entity =>
        {
            entity.ToTable("TipoComprobante");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoComprobanteLetra>(entity =>
        {
            entity.ToTable("TipoComprobanteLetra");

            entity.Property(e => e.FechaAlta).HasColumnType("datetime");
            entity.Property(e => e.Letra)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDePago>(entity =>
        {
            entity.ToTable("TipoDePago");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Concepto)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Estado).HasDefaultValue(1);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TipoDeRecibo>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Descripcion).HasMaxLength(200);
            entity.Property(e => e.Estado).HasDefaultValue(1);
            entity.Property(e => e.Nombre).HasMaxLength(20);
        });

        modelBuilder.Entity<Transferencia>(entity =>
        {
            entity.Property(e => e.FechaDeCarga).HasColumnType("datetime");
            entity.Property(e => e.FechaDeTransf).HasColumnType("datetime");
            entity.Property(e => e.Monto).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NroDeTransf)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.Property(e => e.CuilSocio).HasMaxLength(15);
            entity.Property(e => e.Dia).HasColumnType("datetime");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Apellido).HasMaxLength(50);
            entity.Property(e => e.Dni)
                .HasMaxLength(50)
                .HasColumnName("DNI");
            entity.Property(e => e.Domicilio).HasMaxLength(100);
            entity.Property(e => e.IdRol).HasColumnName("idRol");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Nombre).HasMaxLength(50);
            entity.Property(e => e.Password).HasMaxLength(20);
            entity.Property(e => e.Tel1).HasMaxLength(15);
            entity.Property(e => e.Tel2).HasMaxLength(15);
            entity.Property(e => e.Usuario1)
                .HasMaxLength(20)
                .HasColumnName("Usuario");
        });

        modelBuilder.Entity<UsuariosObjeto>(entity =>
        {
            entity.HasKey(e => e.UsuarioObjetoId).HasName("PK_UsuariosObjetos_");
        });

        modelBuilder.Entity<VdCabecera>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Inspector_Verificacion");

            entity.ToTable("VD_Cabecera");

            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiarioAplicado).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.InteresMensualAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Observaviones)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VdCabecera1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VD_Cabecera_");

            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiarioAplicado).HasColumnType("decimal(8, 6)");
            entity.Property(e => e.InteresMensualAplicado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VdDetalle>(entity =>
        {
            entity.ToTable("VD_Detalle");

            entity.Property(e => e.DeudaGenerada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Estado)
                .HasDefaultValue(0)
                .HasComment("0-ACTIVO / 9-ELIMINADO");
            entity.Property(e => e.FechaDePago)
                .HasDefaultValueSql("(NULL)")
                .HasColumnType("datetime");
            entity.Property(e => e.ImporteDepositado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresGenerado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Periodo).HasColumnType("datetime");
            entity.Property(e => e.Rectificacion).HasDefaultValue(0);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteSocios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoSocios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VdinspectorId).HasColumnName("VDInspectorId");
        });

        modelBuilder.Entity<VdDetalle1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VD_Detalle_");

            entity.Property(e => e.DeudaGenerada).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FechaDePago).HasColumnType("datetime");
            entity.Property(e => e.ImporteDepositado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresGenerado).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Periodo).HasColumnType("datetime");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalAporteSocios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoEmpleados).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TotalSueldoSocios).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.VdinspectorId).HasColumnName("VDInspectorId");
        });

        modelBuilder.Entity<VdInspector>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_InspectorVerificacion");

            entity.ToTable("VD_Inspector");

            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cuit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.Estado).HasComment("0-VD / 1-Acta / 2-Cancel");
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiario).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresMensual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TipoInteres)
                .HasDefaultValue(0)
                .HasComment("0- Manual / 1-AFIP");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VdInspector1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VD_Inspector_");

            entity.Property(e => e.Capital).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Cuit)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CUIT");
            entity.Property(e => e.Desde).HasColumnType("datetime");
            entity.Property(e => e.FechaAsignacion).HasColumnType("datetime");
            entity.Property(e => e.FechaCierre).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.Hasta).HasColumnType("datetime");
            entity.Property(e => e.Interes).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresDiario).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresMensual).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VdPlanesDePago>(entity =>
        {
            entity.ToTable("VD_PlanesDePago");

            entity.Property(e => e.ActaId).HasColumnName("ActaID");
            entity.Property(e => e.Ajuste).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Anticipo).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.AnticipoVencimiento).HasColumnType("datetime");
            entity.Property(e => e.Comentario)
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.CuotaVencimiento).HasColumnType("datetime");
            entity.Property(e => e.CuotasImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Deuda).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeudaAfinanciar)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("DeudaAFinanciar");
            entity.Property(e => e.DeudaConAjuste).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.DeudaConInteres).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.InteresFinanciacionImporte).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.InteresFinanciacionPorcentaje).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.NumeroVd).HasColumnName("NumeroVD");
        });

        modelBuilder.Entity<VdPlanesDePagoDetalle>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_PlanesDePagoDetalle");

            entity.ToTable("VD_PlanesDePagoDetalle");

            entity.Property(e => e.Aamortizar)
                .HasColumnType("decimal(15, 2)")
                .HasColumnName("AAmortizar");
            entity.Property(e => e.Amortizado).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Cancelado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FechaCancela).HasColumnType("datetime");
            entity.Property(e => e.FechaVenc).HasColumnType("datetime");
            entity.Property(e => e.ImporteCobrado).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.ImporteCuota).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.Interes).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.InteresResarcitorio).HasColumnType("decimal(15, 2)");
            entity.Property(e => e.PlanesDePagoId).HasColumnName("PlanesDePagoID");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PagoCon).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Vuelto).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VentasDetalle>(entity =>
        {
            entity.ToTable("VentasDetalle");

            entity.Property(e => e.CodeBar)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PrecioU).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 2)");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
