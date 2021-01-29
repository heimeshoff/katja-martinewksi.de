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
      
  let container id color items =
    div [ Class (sprintf "w-full flex justify-center %s" color)] 
      [
        div [ Class "w-full lg:w-2/3 flex flex-col lg:flex-row items-center justify-center lg:space-x-4 space-y-4 lg:space-y-0  p-8 %s" ; Id id ]
          items
      ]
      

  let landingpage model dispatch =
    div [ Class "flex flex-col justify-start items-center" ]
      [ 
        hero model dispatch
        coaching model dispatch |> container "coaching & training" "bg-white"
        solution_focused model dispatch |> container "solution focused" "bg-gray-100"
        about model dispatch |> container "about me" "bg-white"
      ]


  let render (model:Model) dispatch =  
    div [ Class ""; Id "top"
          OnClick (fun _ -> Clicked_Anywhere |> dispatch )]    
      [ 
        navbar model dispatch
        landingpage model dispatch
        footer model dispatch |> grey_background
      ]