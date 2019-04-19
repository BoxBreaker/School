package student.newsfeeder;



import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.ImageButton;
import android.view.View;


public class NewsFeedMain extends AppCompatActivity {

    ImageButton EconImageButton, TechImageButton, PoliImageButton,BreakingButton;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_news_feed_main);



        EconImageButton = findViewById(R.id.EconButton);
        EconImageButton.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v)
            {
            Intent intentLoadNewActivity = new Intent(NewsFeedMain.this, EconFeed.class);
            startActivity(intentLoadNewActivity);
        }

        });

        TechImageButton = findViewById(R.id.TechButton);
        TechImageButton.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View v)
            {
                Intent intentLoadNewActivity = new Intent(NewsFeedMain.this, TechFeed.class);
                startActivity(intentLoadNewActivity);
            }
        });
        PoliImageButton = findViewById(R.id.PoliButton);
        PoliImageButton.setOnClickListener(new View.OnClickListener()
        {
            @Override
            public void onClick(View V)
            {
                Intent intentLoadNewActivity = new Intent(NewsFeedMain.this, PoliFeed.class);
                startActivity(intentLoadNewActivity);
            }
        });

        BreakingButton = findViewById(R.id.BreakingButton);

        BreakingButton.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                Intent intentLoadNewActivity = new Intent(NewsFeedMain.this, BreakingNews.class);
                startActivity(intentLoadNewActivity);
            }
        });

    }

}
