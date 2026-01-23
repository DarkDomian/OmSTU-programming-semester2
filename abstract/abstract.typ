#set text(
  font: ("Libertinus Serif"),
  size: 14pt
)

#set page(
  paper: "a4",
  margin: (
    left: 3cm,
    right: 1cm,
    top: 2cm,
    bottom: 2cm
  ),
  numbering: "1"
)

#set par(
  leading: 1.5em,
  justify: true,
  first-line-indent: 1.25cm,
  spacing: 1.5em
)

#show heading.where(level: 1): it => {
  set align(center)
  set text(weight: "bold", size: 14pt)
  pagebreak()
  upper(it.body)
}

#show heading.where(level: 2): it => {
  set text(weight: "bold", size: 14pt)
  set par(first-line-indent: 0em)
  it.body
}

#let undertitle(title, width: auto, body) = {
  layout(size => {
    stack(
      dir: ttb,
      body,
      block(inset: (y: 3pt), 
        line(length: 
          if width == auto { 
            measure(body).width 
          } else { width },
          stroke: .5pt
        ),
      ),
      text(size: 9pt)[(#title)]
    )
  })
}

#set figure(supplement: [Рисунок])

#show raw.where(lang: "cpp"): it => {
  block(
    fill: luma(99%),
    inset: 10pt,
    stroke: 0.5pt + black,
    breakable: true,
    width: 100%,
  )[
    #set text(
      font: "JetBrainsMono NF",
      size: 12pt
    )
    #set par(
      leading: 0.6em,
      spacing: 1em
    )
    #set align(left)

    #it
  ]
}

// TITLE PAGE
#set page(numbering: none)
#block(
  breakable: false,
  height: 100%
)[
  #set align(center)
  #set par(first-line-indent: 0cm)

  // HEADER
  #block()[
    #set par(leading: 1.2em, spacing: 1.2em)
    #upper("Министерство Науки и Высшего Образования РФ")
    
    Федеральное государственное автономное образовательное учреждение  
  высшего образования 
  
    #upper("«Омский Государственный технический университет»")
  
    Кафедра «Автоматизированные системы обработки информации и управления» 
  ]

  // ABOUT THE WORK
  #v(1fr)
  #block()[
    #upper("Отчет по лабораторной работе")

    по дисциплине  «Программирование»

  ]

  // STUDENT AND TEACHER
  #v(1fr)
  #columns(2)[
    #colbreak()
    #set align(left)
    #set par(
      leading: 1em,
      spacing: 1em
    )
    

    Выполнил:
    студент группы ЗИВТ-252 Доможиров Д. А.

    Работу проверил: 
    Зубарев А.А., к.т.н., доцент кафедры АСОИУ 

    #set align(center)
    #undertitle("дата, подпись", width: 100%)[]  
  ]

  // FOOTER
  #v(1fr)
  Омск  #datetime.today().year()
]

#set page(numbering: "1")

#outline(depth: 2, title: "Оглавление")