﻿using System;
using System.Collections.Generic;
using System.Linq;
using Sungero.Core;
using Sungero.CoreEntities;
using Sungero.Meetings.Agenda;

namespace Sungero.Meetings
{
  partial class AgendaSharedHandlers
  {

    public virtual void MeetingChanged(Sungero.Meetings.Shared.AgendaMeetingChangedEventArgs e)
    {
      this.FillName();
      
      if (e.NewValue != null && e.NewValue.President != null && _obj.OurSignatory == null &&
          Docflow.PublicFunctions.OfficialDocument.Remote.CanSignByEmployee(_obj, e.NewValue.President))
        _obj.OurSignatory = e.NewValue.President;
    }

  }
}