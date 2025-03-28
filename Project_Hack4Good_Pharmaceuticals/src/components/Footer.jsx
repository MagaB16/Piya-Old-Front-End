import './styles/Footer.css'

function Footer(){
    return(
        <footer>
            <section className="footer">
                <div className="footer-container">
                    <div className="footer-box">
                        <h3>Instagram</h3>
                        <a href="#">Mahammad Babayev</a>
                        <a href="#">Murad Orujov</a>
                    </div>

                    <div className="footer-box">
                        <h3>Contact Details</h3>
                        <a href="#">rasimbabayev9g19@gmail.com</a>
                        <a href="#">morujov48@gmail.com</a>
                    </div>
                </div>
            </section>

            <div className="copyright">
                <h4>
                    Copyright &#169; 2024 BlueSky Developers. All rights reserved.
                </h4>
            </div>
        </footer>
    )
}

export default Footer