namespace Cinema

module State =
  open Elmish


  let init result = 
    { 
      Text = "Initial Katjanewski"
    }


  let update msg model =
    model