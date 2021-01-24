namespace Katjanewski

module View =
  open Fable.React
  open Fable.React.Props

  open Katjanewski.Views.Navigation
  open Katjanewski.Views.Hero
  open Katjanewski.Views.Impressum
  open Katjanewski.Views.Solution
  open Katjanewski.Views.Food
  open Katjanewski.Views.Footer
          

  let landingpage model dispatch =
    div []
      [ 
        hero model dispatch
        solution model dispatch
        food model dispatch
        impressum model dispatch 
      ]


  let render (model:Model) dispatch =  
    div [ Class "relative font-sans"; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        navbar model dispatch
        landingpage model dispatch
        footer model dispatch 
      ]