﻿using _420BytesClient.DT.Scheduler;
using Microsoft.AspNetCore.Mvc;
using Syncfusion.Blazor.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _420BytesClient.App.ViewModels.Scheduler.Interfaces
{
    public interface IAppointment_ViewModel
    {
        int Id { get; set; }
        string Subject { get; set; }
        string Location { get; set; }
        DateTime StartTime { get; set; }
        DateTime EndTime { get; set; }
        string Description { get; set; }
        bool IsAllDay { get; set; }
        string RecurrenceRule { get; set; }
        string RecurrenceException { get; set; }
        int? RecurrenceID { get; set; }
        string ApiUrl { get; set; }

        DateTime CurrentDate { get; set; }
        List<AppointmentData> DataSource { get; set; }

        Task ObtenerTodoPorDocumentoAsync();
        Task AgregarCitaAsync(AppointmentData AppointmentData);
        Task ActualizarCitaAsync(AppointmentData AppointmentData);
        Task BorrarCitaAsync(int Id);
    }
}
