document.addEventListener('DOMContentLoaded',() => {
    const randoButton = document.getElementById('rando');
    randoButton.addEventListener('click',(event) =>{
      const movie = document.getElementById('movieData');
      fetch("https://localhost:44319/Movie")
      .then((response) =>{
        return response.json();
      })
      .then((data) => {
        buildMovie(data)
      })
      .catch((error) => {
        console.log(error);
      })

    })

})
function buildMovie(movie)
{
  const poster = document.createElement('div');
  const info = document.createElement('div');
  const image = document.createElement('img');
  const title = document.createElement("h1");
  const year = document.createElement('h2');
  const rated = document.createElement('h2');
  const runtime = document.createElement('h2');
  const plot = document.createElement('p');
  const genre = document.createElement('h3');

  image.src = movie.poster;
  poster.appendChild(img);
  title.innerText = movie.title;
  year.innerText = movie.year;
  rated.innerText = movie.rated;
  runtime.innerText = movie.runtime;
  plot.innerText = movie.plot;
  genre.innerText = movie.genre;
  
  info.appendChild(title);
  info.appendChild(year);
  info.appendChild(rated);
  info.appendChild(runtime);
  info.appendChild(plot);
  info.appendChild(genre);



}

