USE [TP_CUATRIMESTRAL]
GO
/****** Object:  Table [dbo].[AGENDAS]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AGENDAS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_medico] [int] NULL,
	[dia_inicio] [int] NOT NULL,
	[hora_inicio] [int] NOT NULL,
	[hora_fin] [int] NOT NULL,
	[id_especialidad] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ESPECIALIDADES]    Script Date: 17/07/2022 07:04:23 p. m. ******/
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
/****** Object:  Table [dbo].[ESTADOS]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ESTADOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MEDICOS]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_persona] [int] NOT NULL,
	[nro_matricula] [int] NOT NULL,
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
/****** Object:  Table [dbo].[MEDICOS_X_ESPECIALIDAD]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MEDICOS_X_ESPECIALIDAD](
	[id_medico] [int] NULL,
	[id_especialidad] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PACIENTES]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PACIENTES](
	[id_persona] [int] NOT NULL,
	[id_turno] [int] NULL,
UNIQUE NONCLUSTERED 
(
	[id_persona] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PERSONAS]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PERSONAS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_rol] [int] NULL,
	[nombre] [varchar](50) NULL,
	[apellido] [varchar](50) NULL,
	[dni] [smallint] NOT NULL,
	[cuit] [varchar](11) NOT NULL,
	[telefono] [varchar](20) NULL,
	[email] [varchar](50) NOT NULL,
	[clave] [varchar](20) NOT NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[cuit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ROLES]    Script Date: 17/07/2022 07:04:23 p. m. ******/
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
/****** Object:  Table [dbo].[TURNOS]    Script Date: 17/07/2022 07:04:23 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TURNOS](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[id_medico] [int] NULL,
	[id_especialidad] [int] NULL,
	[id_estado] [int] NULL,
	[observaciones_medico] [varchar](300) NULL,
	[observaciones_paciente] [varchar](300) NULL,
	[hora_turno] [int] NULL,
	[id_paciente] [int] NULL,
	[activo] [bit] NULL,
	[fecha_turno] [varchar](15) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[PACIENTES]  WITH CHECK ADD  CONSTRAINT [FK_Pacientes_Personas] FOREIGN KEY([id_persona])
REFERENCES [dbo].[PERSONAS] ([id])
GO
ALTER TABLE [dbo].[PACIENTES] CHECK CONSTRAINT [FK_Pacientes_Personas]
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD FOREIGN KEY([id_rol])
REFERENCES [dbo].[ROLES] ([id])
GO
ALTER TABLE [dbo].[PERSONAS]  WITH CHECK ADD CHECK  (([dni]>(0)))
GO


insert into PERSONAS
(id_rol,nombre,apellido,dni,cuit,telefono,email,clave,estado)
values
(1,'Laura','Martinez',28765341,'27287653411','1134213322','laura@gmail.com','laura1234',1)


insert into PERSONAS
(id_rol,nombre,apellido,dni,cuit,telefono,email,clave,estado)
values
(2,'Roberto','Medic',20790123,'20207901231','1112890077','robertomedic@gmail.com','robertomedic1234',1)


insert into PERSONAS
(id_rol,nombre,apellido,dni,cuit,telefono,email,clave,estado)
values
(3,'Hernan','Admin',30987234,'20309872341','1156559900','admin@gmail.com','admin1234',1)