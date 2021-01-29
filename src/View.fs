namespace Katjanewski

module View =
  open Fable.React
  open Fable.React.Props

  open Katjanewski.Views.Navigation
  open Katjanewski.Views.Hero
  open Katjanewski.Views.Coaching
  open Katjanewski.Views.Solution_focused
  open Katjanewski.Views.About
  open Katjanewski.Views.Impressum
  open Katjanewski.Views.Footer
          
  let grey_background c = [ c ] |> div [ Class "w-full bg-gray-100 flex justify-center py-6 " ]
      

  let landingpage model dispatch =
    div [ Class "flex flex-col justify-start items-center space-y-16" ]
      [ 
        hero model dispatch
        coaching model dispatch
        solution_focused model dispatch |> grey_background
        about model dispatch
      ]


  let render (model:Model) dispatch =  
    div [ Class ""; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        navbar model dispatch
        landingpage model dispatch
        footer model dispatch |> grey_background
      ]