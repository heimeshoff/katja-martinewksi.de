module Katjanewski.Views.Navigation

open System
open Fable.React
open Fable.React.Props

open Katjanewski

let anchor dispatch (label:String) =
  div [ Class "p-4 text-2xl border-b-2 border-transparent hover:border-red-700 cursor-pointer"
        OnClick (fun e -> e.stopPropagation() ; ScrollTo (label.ToLower()) |> dispatch) ]
    [ str label ]
    

let links model dispatch =
  div [ Class "flex flex-col lg:flex-row items-stretch justify-end" ]
    [ "Coaching & Training" |> anchor dispatch
      "Solution focused" |> anchor dispatch
      "About me" |> anchor dispatch
      "Kontakt" |> anchor dispatch  ]


let navbar (model:Model) dispatch =
  let visibility =
    match model.menu_open with
    | true -> "block"
    | false -> "hidden"
  
  div [ Class "z-50 fixed w-full glass bg-white bg-opacity-50 shadow-lg" ]
    [ div [ Class "lg:hidden" ]
        [ div [ Class "w-full flex flex-row items-center justify-between" ]
            [ div [ Class "text-2xl text-gray-800 p-4 cursor-pointer border-b-2 border-transparent hover:border-red-700"
                    OnClick (fun _ -> Navigate_to Landingpage |> dispatch) ]
                [ str "Martinewski" ]
              button [ Class "flex-no-shrink flex items-center m-4 px-3 py-2 border rounded hover:border-red-700 hover:text-blue-light hover:border-blue-light"
                       OnClick (fun e -> e.stopPropagation() ; Toggle_menu |> dispatch ) ]
                [ svg [ Class "fill-current h-3 w-3" ; HTMLAttr.Custom ("viewBox", "0 0 20 20") ; HTMLAttr.Custom ("xmlns", "http://www.w3.org/2000/svg") ]
                    [ path [ HTMLAttr.Custom ("d", "M0 3h20v2H0V3zm0 6h20v2H0V9zm0 6h20v2H0v-2z") ]
                        [ ] ] ] ]
                
          div [ Class (visibility + " bg-white bg-opacity-50 w-full z-25") ]
            [ links model dispatch] ]  
            
      div [ Class ("hidden lg:flex flex-row items-center justify-center"); Id "navbar" ]
        [ div [ Class "w-4/5 xl:w-2/3 flex flex-col lg:flex-row items-center justify-between" ]
            [ div [ Class "text-2xl text-gray-800 p-4 cursor-pointer border-b-2 border-transparent hover:border-red-700 "  
                    OnClick (fun _ -> Navigate_to Landingpage |> dispatch) ]
                [ str "Martinewski" ]
              links model dispatch ] ] ]