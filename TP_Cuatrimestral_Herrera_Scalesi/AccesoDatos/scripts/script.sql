USE [CLINICA_MEDICA_1]
GO
/****** Object:  Table [dbo].[ADMINISTRADORES]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ADMINISTRADORES](
	[id_persona] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AGENDAS]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGENDAS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_medico] [int] NULL,
	[hora_atencion] [int] NULL,
	[dias_atencion] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CIUDADES]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CIUDADES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_pais] [int] NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESPECIALIDADES]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESPECIALIDADES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESTADOS]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICOS]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICOS](
	[id_persona] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nro_matricula] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICOS_X_ESPECIALIDAD]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICOS_X_ESPECIALIDAD](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_medico] [int] NOT NULL,
	[id_especialidad] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PACIENTES]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PACIENTES](
	[id_persona] [int] NOT NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PAISES]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PAISES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_ciudad] [int] NULL,
	[id_rol] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [smallint] NOT NULL,
	[cuit] [varchar](11) NOT NULL,
	[telefono] [varchar](20) NULL,
	[fecha_nacimiento] [date] NOT NULL,
	[direccion] [varchar](50) NULL,
	[email] [varchar](50) NOT NULL,
	[clave] [varchar](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RECEPCIONISTAS]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RECEPCIONISTAS](
	[id_persona] [int] NOT NULL,
UNIQUE NONCLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ROLES](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TURNOS]    Script Date: 11/06/2022 02:31:45 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TURNOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_medico] [int] NULL,
	[id_paciente] [int] NULL,
	[id_estado] [int] NULL,
	[fecha_turno] [date] NOT NULL,
	[hora_turno] [int] NULL,
	[observaciones] [varchar](300) NULL,
	[diagnostico] [varchar](300) NULL,
	[activo] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ADMINISTRADORES]  WITH CHECK ADD  CONSTRAINT [FK_Administradores_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id])
GO
ALTER TABLE [dbo].[ADMINISTRADORES] CHECK CONSTRAINT [FK_Administradores_Personas]
GO
ALTER TABLE [dbo].[AGENDAS]  WITH CHECK ADD FOREIGN KEY([id_medico])
REFERENCES [dbo].[MEDICOS] ([id])
GO
ALTER TABLE [dbo].[CIUDADES]  WITH CHECK ADD FOREIGN KEY([id_pais])
REFERENCES [dbo].[PAISES] ([id])
GO
ALTER TABLE [dbo].[MEDICOS]  WITH CHECK ADD  CONSTRAINT [FK_Medicos_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id])
GO
ALTER TABLE [dbo].[MEDICOS] CHECK CONSTRAINT [FK_Medicos_Personas]
GO
ALTER TABLE [dbo].[MEDICOS_X_ESPECIALIDAD]  WITH CHECK ADD FOREIGN KEY([id_especialidad])
REFERENCES [dbo].[ESPECIALIDADES] ([id])
GO
ALTER TABLE [dbo].[MEDICOS_X_ESPECIALIDAD]  WITH CHECK ADD FOREIGN KEY([id_medico])
REFERENCES [dbo].[MEDICOS] ([id])
GO
ALTER TABLE [dbo].[PACIENTES]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id])
GO
ALTER TABLE [dbo].[PACIENTES] CHECK CONSTRAINT [FK_Pacientes_Personas]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD FOREIGN KEY([id_ciudad])
REFERENCES [dbo].[CIUDADES] ([id])
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD FOREIGN KEY([id_rol])
REFERENCES [dbo].[ROLES] ([id])
GO
ALTER TABLE [dbo].[RECEPCIONISTAS]  WITH CHECK ADD  CONSTRAINT [FK_Recepcionistas_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id])
GO
ALTER TABLE [dbo].[RECEPCIONISTAS] CHECK CONSTRAINT [FK_Recepcionistas_Personas]
GO
ALTER TABLE [dbo].[TURNOS]  WITH CHECK ADD FOREIGN KEY([id_estado])
REFERENCES [dbo].[ESTADOS] ([id])
GO
ALTER TABLE [dbo].[TURNOS]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Medicos] FOREIGN KEY([id_medico])
REFERENCES [dbo].[MEDICOS] ([id])
GO
ALTER TABLE [dbo].[TURNOS] CHECK CONSTRAINT [FK_Turnos_Medicos]
GO
ALTER TABLE [dbo].[TURNOS]  WITH CHECK ADD  CONSTRAINT [FK_Turnos_Pacientes] FOREIGN KEY([id_paciente])
REFERENCES [dbo].[PACIENTES] ([id])
GO
ALTER TABLE [dbo].[TURNOS] CHECK CONSTRAINT [FK_Turnos_Pacientes]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD CHECK  (([clave]>=(8)))
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD CHECK  (([dni]>(0)))
GO
