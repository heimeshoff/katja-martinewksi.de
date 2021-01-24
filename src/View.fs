namespace Cinema

module View =
  open Fable.React
  open Fable.React.Props


  let render (model:Model) dispatch =
    div [ Class "h-screen flex flex-col items-center justify-start bg-gradient-to-br from-gray-700 to-gray-900" ]
      [ model.Text |> ofString
      ]