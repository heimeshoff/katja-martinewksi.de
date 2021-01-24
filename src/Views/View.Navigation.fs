module Katjanewski.Views.Navigation

open System
open Fable.React
open Fable.React.Props

open Katjanewski

let anchor dispatch (label:String) =
  div [ Class "m-4 font-bold text-2xl hover:border-b border-red-300 cursor-pointer"
        OnClick (fun e -> e.stopPropagation() ; ScrollTo (label.ToLower()) |> dispatch) ]
    [ str label ]
    

let links model dispatch =
  div [ Class "flex flex-col lg:flex-row items-stretch justify-end" ]
    [ "Solution Focussed" |> anchor dispatch
      "Food Saving" |> anchor dispatch
      "Publikationen" |> anchor dispatch
      "Impressum" |> anchor dispatch  ]


let navbar (model:Model) dispatch =
  let visibility =
    match model.menu_open with
    | true -> "block"
    | false -> "hidden"
  
  div [ Class "navbar" ]
    [ div [ Class "lg:hidden navbar navbar-opaque " ]
        [ div [ Class "w-full flex flex-row items-center justify-between" ]
            [ div [ Class "nav-home"
                    OnClick (fun _ -> Navigate_to Landingpage |> dispatch) ]
                [ str "Martinewski" ]
              button [ Class "flex-no-shrink flex items-center m-4 px-3 py-2 border rounded border-white hover:text-blue-light hover:border-blue-light"
                       OnClick (fun e -> e.stopPropagation() ; Toggle_menu |> dispatch ) ]
                [ svg [ Class "fill-current h-3 w-3" ; HTMLAttr.Custom ("viewBox", "0 0 20 20") ; HTMLAttr.Custom ("xmlns", "http://www.w3.org/2000/svg") ]
                    [ path [ HTMLAttr.Custom ("d", "M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z") ]
                        [ ] ] ] ]
                
          div [ Class (visibility + " bg-white w-full z-25") ]
            [ links model dispatch] ]  
            
      div [ Class ("navbar-permanent hidden lg:flex flex-row items-center justify-center navbar"); Id "navbar" ]
        [ div [ Class "w-4/5 xl:w-2/3 flex flex-col lg:flex-row items-center justify-between" ]
            [ div [ Class "nav-home"  
                    OnClick (fun _ -> Navigate_to Landingpage |> dispatch) ]
                [ str "Martinewski" ]
              links model dispatch ] ] ]