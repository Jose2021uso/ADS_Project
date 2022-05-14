﻿using ADSProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ADSProyect.Repository
{
    public interface IProfesorRepository
    {

        List<ProfesoresViewModel> obtenerProfesores();

        int agregarProfesor(ProfesoresViewModel profesoresViewModel);

        int actualizarProfesor(int idProfesor, ProfesoresViewModel profesoresViewModel);

        bool eliminarProfesor(int idProfesor);

        ProfesoresViewModel obtenerProfesorPorID(int idProfesor);


    }
}
