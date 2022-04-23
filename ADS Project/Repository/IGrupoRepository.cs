﻿using ADS_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADS_Project.Repository
{
    public interface IGrupoRepository
    {
        List<GrupoViewModel> obtenerGrupos();

        int agregarGrupo(GrupoViewModel grupoViewModel);

        int actualizarGrupo(int idGrupo, GrupoViewModel grupoViewModel);

        bool eliminarGrupo(int idGrupo);

        GrupoViewModel obtenerGrupoPorID(int idGrupo);
    }
}
