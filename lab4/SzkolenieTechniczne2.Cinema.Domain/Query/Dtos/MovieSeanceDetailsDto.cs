﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzkolenieTechniczne2.Cinema.Domain.Query.Dtos
{
    public sealed record MovieSeanceDetailsDto (
        long movieId,
        long seanceId,
        string movieName,
        DateTime seanceDate );

}
