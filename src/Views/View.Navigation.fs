module Katjanewski.Views.Navigation

open System
open Fable.React
open Fable.React.Props

open Katjanewski

let anchor dispatch (label:String) =
  div [ Class "p-4 text-2xl w-full lg:w-auto border-b-2 border-transparent hover:border-red-700 cursor-pointer"
        OnClick (fun e -> e.stopPropagation() ; ScrollTo (label.ToLower()) |> dispatch) ]
    [ str label ]
    

let links model dispatch =
  [ "Coaching & Training" |> anchor dispatch
    "Solution focused" |> anchor dispatch
    "About me" |> anchor dispatch
    "Kontakt" |> anchor dispatch  ]


let brand_logo dispatch = 
  div [ Class "text-2xl text-gray-800 p-4 ml-4 cursor-pointer border-b-2 border-transparent hover:border-red-700"
        OnClick (fun _ -> Navigate_to Landingpage |> dispatch) ]
    [ str "Martinewski" ]


let toggle_menu dispatch = 
  button [ Class "flex-no-shrink flex items-center m-4 px-3 py-2 border-2 rounded-md hover:text-red-700 hover:border-red-700 hover:text-blue-light hover:border-blue-light focus:outline-none"
           OnClick (fun e -> e.stopPropagation() ; Toggle_menu |> dispatch ) ]
    [ svg [ Class "fill-current h-4 w-4" ; HTMLAttr.Custom ("viewBox", "0 0 20 20") ; HTMLAttr.Custom ("xmlns", "http://www.w3.org/2000/svg") ]
        [ path [ HTMLAttr.Custom ("d", "M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z") ] [ ] ] ] 


let mobile_menu dispatch model = 
  div [ Class "lg:hidden" ]
    [
      div [ Class "flex flex-row items-center justify-between"]
        [
          brand_logo dispatch
          toggle_menu dispatch 
        ]
      if model.menu_open then
        div [ Class "flex flex-col items-center space-y-4 pl-4" ]
          ( links model dispatch )
    ]


let desktop_model dispatch model = 
  div [ Class "hidden lg:block w-full" ]
    [
      div [ Class "flex flex-row justify-between" ]
        [
          brand_logo dispatch
          div [ Class "hidden lg:flex flex-row items-center space-x-4 pr-8" ]    
            ( links model dispatch )
        ]
    ]


let navbar (model:Model) dispatch =
  div [ Class "z-50 fixed w-full glass bg-white shadow-lg" ]
    [ 
      mobile_menu dispatch model 
      desktop_model dispatch model 
    ]